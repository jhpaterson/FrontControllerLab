using System.Web;

namespace FrontControllerLab.Controller.Storage
{
    public enum ViewStorageKeys
    {
        Users,
        Packages
    }

    public class ViewStorage
    {
        public void Add(ViewStorageKeys key, object value)
        {
            HttpContext.Current.Items.Add(key.ToString(), value);
        }

        public object Get(ViewStorageKeys key)
        {
            return HttpContext.Current.Items[key.ToString()];
        }
    }
}