using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;


namespace Editor.Core
{
    public class EditorFontCollection
    {
        private static Font fontAwesomeSolid;

        public Font FontAwesomeSolid => fontAwesomeSolid;

        public EditorFontCollection() 
        {
            if (fontAwesomeSolid == null)
            {
                LoadFontFromResource("Editor.Fonts.Font_Awesome_6_Free_Solid_900.otf");
            }
        }

        //[Nome do Assembly].[Nome da Pasta].[Nome do Arquivo]
        private void LoadFontFromResource(string resourceName)
        {
            var privateFontCollection = new PrivateFontCollection();

            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream fontStream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (fontStream != null)
                    {
                        byte[] fontData = new byte[fontStream.Length];
                        fontStream.Read(fontData, 0, (int)fontStream.Length);

                        // ### AQUI ESTÁ A CORREÇÃO ###
                        // Alocar memória não gerenciada para a fonte
                        IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                        // Copiar os bytes da fonte para a memória alocada
                        Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                        // Adicionar a fonte à coleção de fontes privadas
                        privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);

                        // Liberar a memória não gerenciada após adicionar a fonte
                        Marshal.FreeCoTaskMem(fontPtr);
                        // ### FIM DA CORREÇÃO ###

                        // Agora que a fonte foi adicionada à coleção, podemos criar uma instância de Font
                        if (privateFontCollection.Families.Length > 0)
                        {
                            // Encontre a família de fontes correta pelo nome ou use a primeira.
                            // Para "Font Awesome 6 Free-Solid-900.otf", o nome da família é "Font Awesome 6 Free Solid"
                            FontFamily faFamily = null;
                            foreach (FontFamily ff in privateFontCollection.Families)
                            {
                                if (ff.Name == "Font Awesome 6 Free Solid") // Verifique o nome exato da sua fonte
                                {
                                    faFamily = ff;
                                    break;
                                }
                            }

                            if (faFamily != null)
                            {
                                fontAwesomeSolid = new Font(faFamily, 9, FontStyle.Regular);
                            }
                            else
                            {
                                MessageBox.Show("Família de fontes 'Font Awesome 6 Free Solid' não encontrada na coleção.", "Erro de Fonte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Recurso '{resourceName}' não encontrado. Verifique o nome.", "Erro de Recurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a fonte do recurso: {ex.Message}", "Erro de Carregamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
