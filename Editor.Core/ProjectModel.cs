namespace Editor.Core
{
    /// <summary>
    /// Representa um modelo de projeto.
    /// </summary>
    public class ProjectModel
    {
        /// <summary>
        /// O caminho do arquivo carregado.
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// O nome do projeto.
        /// </summary>
        public string? Name { get; set; }
    }
}
