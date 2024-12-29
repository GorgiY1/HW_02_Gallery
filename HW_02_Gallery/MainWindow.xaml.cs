using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Serialization;

namespace HW_02_Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Images> gallery = new List<Images>();
        //static List<Images2> gallery2 = new List<Images2>();
        static Images im_tmp = new Images();
        public MainWindow()
        {
            InitializeComponent();

            XmlSerializer formatter = new XmlSerializer(typeof(List<Images>));
            try
            {
                using (FileStream stream = File.OpenRead("Marks.xml"))
                {
                    gallery = formatter.Deserialize(stream) as List<Images>;
                }
            }
            catch
            {
                for (int i = 0; i < stack_images.Children.Count; i++)
                {
                    if (stack_images.Children[i] is Image im)
                    {
                       gallery.Add(new Images { /*image_coll = im,*/ Path = im.Source.ToString(), Mark = "0" });
                    }
                }
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        { 
            if (sender is Slider slider)
            {
                for (int j = 0; j < gallery.Count && j < stack_images.Children.Count; j++)
                {
                    if (stack_images.Children[j] is Image image && j == slider.Value)
                    {
                        stack_images.Children[j].Visibility = Visibility.Visible;

                        for (int l = 0; l < radio_btns.Children.Count; l++)
                        {
                            if (radio_btns.Children[l] is RadioButton rd_btn)
                            {
                                rd_btn.IsChecked = false;
                                if (rd_btn.Content is string rdb_content1 && gallery[j].Mark == rdb_content1)
                                {
                                    if (gallery[j].Mark == "0") 
                                    {
                                        rd_btn.IsChecked = false;
                                        break;
                                    }
                                    else
                                    {
                                        rd_btn.IsChecked = true;
                                        break;
                                    }
                                }
                            }
                        }
                        

                        //for (int l = 0; l < radio_btns.Children.Count; l++)
                        //{
                        //    bool ischecked2 = false;
                        //    foreach (Images item in gallery)
                        //    {
                        //        if (radio_btns.Children[l] is RadioButton rd_btn && rd_btn.Content is string rdb_content && int.Parse(rdb_content)-1 == l)
                        //        {
                        //            if (gallery.IndexOf(item) == (int)slider.Value)
                        //            {
                        //                ((RadioButton)radio_btns.Children[l]).IsChecked = false;

                        //                ischecked2 = true;
                        //                break;
                        //            }
                        //        }
                        //    }
                            
                        //    if (ischecked2)
                        //    {
                        //        break;
                        //    }
                        //}

                        for (int i = 0; i < stack_images.Children.Count; i++)
                        {
                            if (i != j)
                            {
                                stack_images.Children[i].Visibility = Visibility.Collapsed;
                            }
                            if (i == j)
                            {
                                stack_images.Children[j].Visibility = Visibility.Visible;
                            }
                        }
                    }
                }
            }
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (stack_images.Children.Count >= slider_imeges.Value - 1)
            {
                slider_imeges.Value--;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if ( slider_imeges.Value + 1 <= slider_imeges.Maximum)
            {
                slider_imeges.Value++;
            }
        }

        private void rdbtn_Chacked(object sender, RoutedEventArgs e)
        {
            for (int j = 0; j < gallery.Count; j++)
            {
                if (stack_images.Children[j] is Image image && j == slider_imeges.Value)
                {
                    for (int l = 0; l < radio_btns.Children.Count; l++)
                    {
                        if (radio_btns.Children[l] is RadioButton rd_btn)
                        {
                            if (rd_btn.IsChecked == true)
                            {
                                if (rd_btn.Content is string rdb_content1)
                                {
                                    gallery[j].Mark = rdb_content1;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Images>));
                using (FileStream stream = File.Create("Marks.xml"))
                {
                    formatter.Serialize(stream, gallery);
                }
                //MessageBox.Show("\nSerialize OK!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void radio_btns_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
