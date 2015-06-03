using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SecurityProtocolManagerVS2013
{
	#region class UserCacheSettings

	[DataContract(Namespace="")]
	[KnownType(typeof(SecurityProtocolType))]
	public class UserCacheSettings
	{
		public UserCacheSettings()
		{
			this.GeneralStore = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);
		}

		[DataMember]
		public Dictionary<string,object> GeneralStore { get; set; }
	}

	#endregion

	public static class UserCacheManager
	{
		#region | Properties & Members |

		public const string LOCAL_USER_SETTINGS_FILENAME = "usercache.xml";

		private static UserCacheSettings _cachedSettings { get; set; }

		private static object _fileLock = new object();
		private static object _cacheLock = new object();

		public static string UserSettingsCacheDirectory
		{
			get
			{
				Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

				string dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					"VS2013SecurityProtocolManager", "UserSettings", string.Format("{0}_{1}", v.Major, v.Minor));
				if ( !Directory.Exists(dirPath) )
					Directory.CreateDirectory(dirPath);

				return dirPath;
			}
		}

		public static UserCacheSettings CachedSettings
		{
			get
			{
				lock ( _cacheLock )
				{
					if ( _cachedSettings == null )
						_cachedSettings = UserCacheManager.GetCachedSettings();

					return _cachedSettings;
				}
			}
		}

		#endregion

		public static T Get<T>(string key, Func<T> getDefault = null)
		{
			if ( getDefault == null )
				getDefault = () => default(T);

			if ( CachedSettings.GeneralStore.ContainsKey(key) )
				return (T)CachedSettings.GeneralStore[key];

			return getDefault.Invoke();
		}

		public static void Set(string key, object value)
		{
			CachedSettings.GeneralStore[key] = value;
			SaveCachedSettings();
		}

		public static void RefreshCache()
		{
			lock ( _cacheLock )
			{
				_cachedSettings = null;
			}
		}

		private static UserCacheSettings GetCachedSettings(string fileName = UserCacheManager.LOCAL_USER_SETTINGS_FILENAME)
		{
			lock ( _fileLock )
			{
				string filepath = System.IO.Path.Combine(UserSettingsCacheDirectory, fileName);
				UserCacheSettings settings = new UserCacheSettings();

				// if DNE, write file
				if ( !System.IO.File.Exists(filepath) )
				{
					using ( System.IO.FileStream fs = System.IO.File.Create(filepath) )
					{
						using ( XmlWriter Writer = XmlTextWriter.Create(fs, new XmlWriterSettings
						{
							CloseOutput = false,
							ConformanceLevel = ConformanceLevel.Document,
							Encoding = Encoding.UTF8,
							Indent = true,
							IndentChars = "\t",
							NamespaceHandling = NamespaceHandling.OmitDuplicates,
							NewLineChars = Environment.NewLine,
							NewLineHandling = NewLineHandling.Replace,
							NewLineOnAttributes = true,
							OmitXmlDeclaration = false
						}) )
						{
							new DataContractSerializer(typeof(UserCacheSettings)).WriteObject(Writer, settings);
							Writer.Flush();
						}

						fs.Flush(true);
						fs.Close();
					}
				}

				// read settings from file and return
				try
				{
					using ( XmlReader Reader = XmlTextReader.Create(filepath) )
						settings = (UserCacheSettings)new DataContractSerializer(typeof(UserCacheSettings)).ReadObject(Reader);
				}
				catch ( System.Exception err )
				{ 
					// An exception here most likely means the file was not written correctly and has been corrupted.
					// Delete the existing one and return a fresh cache object.
					File.Delete(filepath);
					settings = new UserCacheSettings();

					// inform the user that something happened
					FormShowMessage.ShowError(err, "Non-fatal error encountered.", "Non-fatal error:", MessageBoxIcon.Warning);
				}

				return settings;
			}
		}

		private static void SaveCachedSettings(UserCacheSettings toSave = null, string fileName = UserCacheManager.LOCAL_USER_SETTINGS_FILENAME)
		{
			if ( toSave == null )
				toSave = UserCacheManager.CachedSettings;

			lock ( _fileLock )
			{
				string filepath = System.IO.Path.Combine(UserSettingsCacheDirectory, fileName);

				if ( !System.IO.File.Exists(filepath) )
					using ( System.IO.FileStream fs = System.IO.File.Create(filepath) )
						fs.Close();

				using ( System.IO.FileStream fs = System.IO.File.Create(filepath) )
				{
					using ( XmlWriter Writer = XmlTextWriter.Create(fs, new XmlWriterSettings
					{
						CloseOutput = false,
						ConformanceLevel = ConformanceLevel.Document,
						Encoding = Encoding.UTF8,
						Indent = true,
						IndentChars = "\t",
						NamespaceHandling = NamespaceHandling.OmitDuplicates,
						NewLineChars = Environment.NewLine,
						NewLineHandling = NewLineHandling.Replace,
						NewLineOnAttributes = true,
						OmitXmlDeclaration = false
					}) )
					{
						new DataContractSerializer(typeof(UserCacheSettings)).WriteObject(Writer, toSave);
						Writer.Flush();
					}

					fs.Flush(true);
					fs.Close();
				}

				UserCacheManager.RefreshCache();
			}
		}
	}
}
