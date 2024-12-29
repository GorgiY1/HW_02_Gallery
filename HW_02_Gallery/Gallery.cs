using System;
using System.Windows.Controls;

namespace HW_02_Gallery
{
    [Serializable]
    public class Images
    {
        public string Path { get; set; }
        public string Mark { get; set; }

        //[NonSerialized]
        //public Image image_coll;
    }

    //[Serializable]
    //public class Images2
    //{
    //    public string Path { get; set; }
    //    public string Mark { get; set; }
   // }
    //class Gallery
    //{
    //    public static Dictionary<Image, int> _images;
    //    public Gallery()
    //    {
    //        _images = new Dictionary<Image, int>();
    //        //_images.Add("/bdd20b7d5b34486da3db84ce0c808b7a.jpg", 0);
    //        //_images.Add("/1660828639184470996.png", 0);
    //        //_images.Add("/166082864116043105.png", 0);
    //        //_images.Add("/1660828646123530957.png", 0);
    //        //_images.Add("/2f62db1ee120c81573d8813ac369952808f222aa_1024.jpg", 0);
    //        //_images.Add("/39f2bade-723c57083305190737254934fe2a4064.jpeg", 0);
    //        //_images.Add("/field_image_000foto_planeta_2016.jpg", 0);
    //        //_images.Add("/images (1).jpg", 0);
    //        //_images.Add("/images (2).jpg", 0);
    //        //_images.Add("/images (3).jpg", 0);
    //        //_images.Add("/images (4).jpg", 0);
    //        //_images.Add("/images (5).jpg", 0);
    //        //_images.Add("/images.jpg", 0);
    //        //_images.Add("/Без названия.jpg", 0);
    //        //_images.Add("/mp-cover.jpg", 0);
    //    }
    //    public Gallery(int grade, Image path)
    //    {
    //        _images = new Dictionary<Image, int>();
    //        _images.Add(path, grade);
    //    }
    //    public void Add(Image path)
    //    {
    //        _images.Add(path, 0);
    //    }
    //    public void Add(Image path, int grade)
    //    {
    //        _images.Add(path, grade);
    //    }

    //    //public void Save_To_File(string path)
    //    //{
    //    //    using (FileStream fs = new FileStream(path,FileMode.CreateNew,FileAccess.Write))
    //    //    {
    //    //        using (StreamWriter sw = new StreamWriter(path))
    //    //        {
    //    //            foreach (string item in _images.Keys)
    //    //            {
    //    //                sw.WriteLine($"{item}, {_images[item]}");
    //    //            }
    //    //        }
    //    //    }
    //    //}

    //    //public void Load_From_File(string path)
    //    //{
    //    //    using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
    //    //    {
    //    //        using (StreamWriter sw = new StreamWriter(path))
    //    //        {
    //    //            foreach (string item in _images.Keys)
    //    //            {
    //    //                sw.WriteLine($"{item}, {_images[item]}");
    //    //            }
    //    //        }
    //    //    }
    //    //}
    //}
}
