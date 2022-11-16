using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace Restauradores_De_Banco.Classes
{    public class Powershell
    {
        public string mensagem = "";

        public Powershell()
        {
        }

        /// <summary>
        /// Executa o comando no PowerShell
        /// <para><returns>Retorna um boolean se funcionou ou não</returns></para>
        /// <code>Armazena na variável "mensagem" a resposta do PowerShell</code>
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public bool PowerShell(String comando)
        {
            try
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();
                pipeline.Commands.AddScript(comando);
                pipeline.Commands.Add("Out-String");
                Collection<PSObject> results = pipeline.Invoke();
                runspace.Close();
                StringBuilder stringBuilder = new();
                foreach (PSObject pSObject in results)
                    stringBuilder.Append(pSObject.ToString());
                Application.DoEvents();
                mensagem = stringBuilder.ToString();
                return true;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }
    }
}
