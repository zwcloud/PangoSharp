// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Context : GLib.Object {

		public Context (IntPtr raw) : base(raw) {}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_new();

		public Context () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Context)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = pango_context_new();
		}

		[StructLayout (LayoutKind.Sequential)]
		struct PangoContextClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, PangoContextClass> class_structs;

		static PangoContextClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, PangoContextClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				PangoContextClass class_struct = (PangoContextClass) Marshal.PtrToStructure (class_ptr, typeof (PangoContextClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, PangoContextClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_base_dir(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_base_dir(IntPtr raw, int direction);

		public Pango.Direction BaseDir { 
			get {
				int raw_ret = pango_context_get_base_dir(Handle);
				Pango.Direction ret = (Pango.Direction) raw_ret;
				return ret;
			}
			set {
				pango_context_set_base_dir(Handle, (int) value);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_base_gravity(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_base_gravity(IntPtr raw, int gravity);

		public Pango.Gravity BaseGravity { 
			get {
				int raw_ret = pango_context_get_base_gravity(Handle);
				Pango.Gravity ret = (Pango.Gravity) raw_ret;
				return ret;
			}
			set {
				pango_context_set_base_gravity(Handle, (int) value);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_font_description(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_font_description(IntPtr raw, IntPtr desc);

		public Pango.FontDescription FontDescription { 
			get {
				IntPtr raw_ret = pango_context_get_font_description(Handle);
				Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
				return ret;
			}
			set {
				pango_context_set_font_description(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_font_map(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_font_map(IntPtr raw, IntPtr font_map);

		public Pango.FontMap FontMap { 
			get {
				IntPtr raw_ret = pango_context_get_font_map(Handle);
				Pango.FontMap ret = GLib.Object.GetObject(raw_ret) as Pango.FontMap;
				return ret;
			}
			set {
				pango_context_set_font_map(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_gravity(IntPtr raw);

		public Pango.Gravity Gravity { 
			get {
				int raw_ret = pango_context_get_gravity(Handle);
				Pango.Gravity ret = (Pango.Gravity) raw_ret;
				return ret;
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_gravity_hint(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_gravity_hint(IntPtr raw, int hint);

		public Pango.GravityHint GravityHint { 
			get {
				int raw_ret = pango_context_get_gravity_hint(Handle);
				Pango.GravityHint ret = (Pango.GravityHint) raw_ret;
				return ret;
			}
			set {
				pango_context_set_gravity_hint(Handle, (int) value);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_language(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_language(IntPtr raw, IntPtr language);

		public Pango.Language Language { 
			get {
				IntPtr raw_ret = pango_context_get_language(Handle);
				Pango.Language ret = raw_ret == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Language), false);
				return ret;
			}
			set {
				pango_context_set_language(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_matrix(IntPtr raw);

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_matrix(IntPtr raw, IntPtr value);

		public Pango.Matrix Matrix { 
			get {
				IntPtr raw_ret = pango_context_get_matrix(Handle);
				Pango.Matrix ret = Pango.Matrix.New (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				pango_context_set_matrix(Handle, native_value);
				value = Pango.Matrix.New (native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_metrics(IntPtr raw, IntPtr desc, IntPtr language);

		public Pango.FontMetrics GetMetrics(Pango.FontDescription desc, Pango.Language language) {
			IntPtr raw_ret = pango_context_get_metrics(Handle, desc == null ? IntPtr.Zero : desc.Handle, language == null ? IntPtr.Zero : language.Handle);
			Pango.FontMetrics ret = raw_ret == IntPtr.Zero ? null : (Pango.FontMetrics) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontMetrics), false);
			return ret;
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_load_font(IntPtr raw, IntPtr desc);

		public Pango.Font LoadFont(Pango.FontDescription desc) {
			IntPtr raw_ret = pango_context_load_font(Handle, desc == null ? IntPtr.Zero : desc.Handle);
			Pango.Font ret = GLib.Object.GetObject(raw_ret) as Pango.Font;
			return ret;
		}

		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_load_fontset(IntPtr raw, IntPtr desc, IntPtr language);

		public Pango.Fontset LoadFontset(Pango.FontDescription desc, Pango.Language language) {
			IntPtr raw_ret = pango_context_load_fontset(Handle, desc == null ? IntPtr.Zero : desc.Handle, language == null ? IntPtr.Zero : language.Handle);
			Pango.Fontset ret = GLib.Object.GetObject(raw_ret) as Pango.Fontset;
			return ret;
		}

#endregion
	}
}
