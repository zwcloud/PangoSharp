// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.TabAlignGType))]
	public enum TabAlign {

		Left,
	}

	internal class TabAlignGType {
		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_tab_align_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_tab_align_get_type ());
			}
		}
	}
#endregion
}