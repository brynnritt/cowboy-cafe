using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Extention
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finr the first ancestor in the Visual Tree that has the specfied type,
        /// or null if no ancestor is found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T:DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent);
        }
    }
}
