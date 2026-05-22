namespace LAB14_Ejer2Repaso.Models
{
    public class Album
    {
        public string TituloAlbum { get; set; } = string.Empty;
        public string ArtistaAlbum { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get; set; } = DateTime.Now;

        public List<Cancion> Canciones { get; set; } = new List<Cancion>();
    }
}
