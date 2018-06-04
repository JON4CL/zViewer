using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;

namespace zViewer
{
    public class IniManager
    {
        public static string iniFilePath = System.Windows.Forms.Application.StartupPath + Path.DirectorySeparatorChar + "conf.ini";
        public static IniManager iniManager = new IniManager();

        private string sBuffer;

        public static string IniGet(string sFileName, string sSection, string sKeyName, string sDefault)
        {
            //--------------------------------------------------------------------------
            // Devuelve el valor de una clave de un fichero INI
            // Los par�metros son:
            //   sFileName   El fichero INI
            //   sSection    La secci�n de la que se quiere leer
            //   sKeyName    Clave
            //   sDefault    Valor opcional que devolver� si no se encuentra la clave
            //--------------------------------------------------------------------------
            int ret;
            string sRetVal;
            //
            sRetVal = new string(' ', 255);
            //
            ret = GetPrivateProfileString(sSection, sKeyName, sDefault, sRetVal, sRetVal.Length, sFileName);
            if (ret == 0)
            {
                return sDefault;
            }
            else
            {
                return sRetVal.Substring(0, ret);
            }
        }
        public static bool IniWrite(string sFileName, string sSection, string sKeyName, string sValue)
        {
            //--------------------------------------------------------------------------
            // Guarda los datos de configuraci�n
            // Los par�metros son los mismos que en LeerIni
            // Siendo sValue el valor a guardar
            //
            if (WritePrivateProfileString(sSection, sKeyName, sValue, sFileName) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region " Declaraciones para leer ficheros INI"
        // Leer todas las secciones de un fichero INI, esto seguramente no funciona en Win95
        // Esta funci�n no estaba en las declaraciones del API que se incluye con el VB
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileSectionNames(
            string lpszReturnBuffer,  // address of return buffer
            int nSize,             // size of return buffer
            string lpFileName         // address of initialization filename
        );
        // Leer una secci�n completa
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileSection(
            string lpAppName,         // address of section name
            string lpReturnedString,  // address of return buffer
            int nSize,             // size of return buffer
            string lpFileName         // address of initialization filename
        );
        // Leer una clave de un fichero INI
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileString(
            string lpAppName,        // points to section name
            string lpKeyName,        // points to key name
            string lpDefault,        // points to default string
            string lpReturnedString, // points to destination buffer
            int nSize,            // size of destination buffer
            string lpFileName        // points to initialization filename
        );
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileString(
            string lpAppName,        // points to section name
            int lpKeyName,        // points to key name
            string lpDefault,        // points to default string
            string lpReturnedString, // points to destination buffer
            int nSize,            // size of destination buffer
            string lpFileName        // points to initialization filename
        );
        #endregion

        #region " Declaraciones para escribir en ficheros INI"
        // Escribir una clave de un fichero INI (tambi�n para borrar claves y secciones)
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int WritePrivateProfileString(
            string lpAppName,  // pointer to section name
            string lpKeyName,  // pointer to key name
            string lpString,   // pointer to string to add
            string lpFileName  // pointer to initialization filename
        );
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int WritePrivateProfileString(
            string lpAppName,  // pointer to section name
            string lpKeyName,  // pointer to key name
            int lpString,   // pointer to string to add
            string lpFileName  // pointer to initialization filename
            );
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int WritePrivateProfileString(
            string lpAppName,  // pointer to section name
            int lpKeyName,  // pointer to key name
            int lpString,   // pointer to string to add
            string lpFileName  // pointer to initialization filename
            );
        //
        #endregion

        #region " Declaraciones para borrar en ficheros INI"
        public void IniDeleteKey(string sIniFile, string sSection, string sKey)
        {
            //--------------------------------------------------------------------------
            // Borrar una clave o entrada de un fichero INI                  (16/Feb/99)
            // Si no se indica sKey, se borrar� la secci�n indicada en sSection
            // En otro caso, se supone que es la entrada (clave) lo que se quiere borrar
            //
            // Para borrar una secci�n se deber�a usar IniDeleteSection
            //
            if (sKey == "")
            {
                // Borrar una secci�n
                WritePrivateProfileString(sSection, 0, 0, sIniFile);
            }
            else
            {
                // Borrar una entrada
                WritePrivateProfileString(sSection, sKey, 0, sIniFile);
            }
        }
        public void IniDeleteSection(string sIniFile, string sSection)
        {
            //--------------------------------------------------------------------------
            // Borrar una secci�n de un fichero INI                          (04/Abr/01)
            // Borrar una secci�n
            WritePrivateProfileString(sSection, 0, 0, sIniFile);
        }
        #endregion

        #region " Declaraciones para obtener conjuntos de datos de ficheros INI"
        public string[] IniGetSection(string sFileName, string sSection)
        {
            //--------------------------------------------------------------------------
            // Lee una secci�n entera de un fichero INI                      (27/Feb/99)
            // Adaptada para devolver un array de string                     (04/Abr/01)
            //
            // Esta funci�n devolver� un array de �ndice cero
            // con las claves y valores de la secci�n
            //
            // Par�metros de entrada:
            //   sFileName   Nombre del fichero INI
            //   sSection    Nombre de la secci�n a leer
            // Devuelve:
            //   Un array con el nombre de la clave y el valor
            //   Para leer los datos:
            //       For i = 0 To UBound(elArray) -1 Step 2
            //           sClave = elArray(i)
            //           sValor = elArray(i+1)
            //       Next
            //
            string[] aSeccion;
            int n;
            //
            aSeccion = new string[0];
            //
            // El tama�o m�ximo para Windows 95
            sBuffer = new string('\0', 32767);
            //
            n = GetPrivateProfileSection(sSection, sBuffer, sBuffer.Length, sFileName);
            //
            if (n > 0)
            {
                // Cortar la cadena al n�mero de caracteres devueltos
                // menos los dos �ltimos que indican el  final de la cadena
                sBuffer = sBuffer.Substring(0, n - 2).TrimEnd();
                //
                // Cada una de las entradas estar� separada por un Chr$(0)
                // y cada valor estar� en la forma: clave = valor
                aSeccion = sBuffer.Split(new char[] { '\0', '=' });
            }
            // Devolver el array
            return aSeccion;
        }
        public string[] IniGetSections(string sFileName)
        {
            //--------------------------------------------------------------------------
            // Devuelve todas las secciones de un fichero INI                (27/Feb/99)
            // Adaptada para devolver un array de string                     (04/Abr/01)
            //
            // Esta funci�n devolver� un array con todas las secciones del fichero
            //
            // Par�metros de entrada:
            //   sFileName   Nombre del fichero INI
            // Devuelve:
            //   Un array con todos los nombres de las secciones
            //   La primera secci�n estar� en el elemento 1,
            //   por tanto, si el array contiene cero elementos es que no hay secciones
            //
            int n;
            string[] aSections;
            //
            aSections = new string[0];
            //
            // El tama�o m�ximo para Windows 95
            sBuffer = new string('\0', 32767);
            //
            // Esta funci�n del API no est� definida en el fichero TXT
            n = GetPrivateProfileSectionNames(sBuffer, sBuffer.Length, sFileName);
            //
            if (n > 0)
            {
                // Cortar la cadena al n�mero de caracteres devueltos
                // menos los dos �ltimos que indican el  final de la cadena
                sBuffer = sBuffer.Substring(0, n - 2).TrimEnd();
                aSections = sBuffer.Split('\0');
            }
            // Devolver el array
            return aSections;
        }
        #endregion
    }
}