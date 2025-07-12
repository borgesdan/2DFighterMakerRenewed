using System.Drawing;
using System.Numerics;

namespace Editor.Models
{
    public class AnimationFrameModel
    {
        /// <summary>
        /// Obtém ou define o arquivo de origem do frame.
        /// </summary>
        public string? SourceFile { get; set; }

        /// <summary>
        /// Obtém ou define os limites do frame.
        /// </summary>
        public Rectangle Bounds { get; set; }        

        /// <summary>
        /// Define a duração do frame.
        /// Se nulo a classe de animação deve ser responsável por definir um valor.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Define os efeitos de espelhamento do frame.
        /// </summary>
        public Mirroring Mirroring { get; set; } = Mirroring.None;

        /// <summary>
        /// Define a posição do eixo de origem do frame.
        /// Se nulo a classe de animação deve ser responsável por definir um valor.
        /// </summary>
        public Vector2? Origin { get; set; }

        /// <summary>
        /// Define a escala de tamanho do frame.
        /// Se nulo a classe de animação deve ser responsável por definir um valor.
        /// </summary>
        public Vector2? Scale { get; set; }

        /// <summary>
        /// Um valor associado.
        /// </summary>
        public object? Tag { get; set; }
    }
}
