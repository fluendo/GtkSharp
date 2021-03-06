// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufLoader : GLib.Object {

		public PixbufLoader (IntPtr raw) : base(raw) {}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_loader_new();

		public PixbufLoader () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufLoader)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gdk_pixbuf_loader_new();
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_loader_new_with_mime_type(IntPtr mime_type, out IntPtr error);

		public unsafe PixbufLoader (string mime_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufLoader)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			IntPtr error = IntPtr.Zero;
			Raw = gdk_pixbuf_loader_new_with_mime_type(native_mime_type, out error);
			GLib.Marshaller.Free (native_mime_type);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_loader_new_with_type(IntPtr image_type, out IntPtr error);

		public static unsafe PixbufLoader NewWithType(string image_type)
		{
			IntPtr native_image_type = GLib.Marshaller.StringToPtrGStrdup (image_type);
			IntPtr error = IntPtr.Zero;
			PixbufLoader result = new PixbufLoader (gdk_pixbuf_loader_new_with_type(native_image_type, out error));
			GLib.Marshaller.Free (native_image_type);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return result;
		}

		[GLib.Signal("size-prepared")]
		public event Gdk.SizePreparedHandler SizePrepared {
			add {
				this.AddSignalHandler ("size-prepared", value, typeof (Gdk.SizePreparedArgs));
			}
			remove {
				this.RemoveSignalHandler ("size-prepared", value);
			}
		}

		[GLib.Signal("closed")]
		public event System.EventHandler Closed {
			add {
				this.AddSignalHandler ("closed", value);
			}
			remove {
				this.RemoveSignalHandler ("closed", value);
			}
		}

		[GLib.Signal("area-updated")]
		public event Gdk.AreaUpdatedHandler AreaUpdated {
			add {
				this.AddSignalHandler ("area-updated", value, typeof (Gdk.AreaUpdatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("area-updated", value);
			}
		}

		[GLib.Signal("area-prepared")]
		public event System.EventHandler AreaPrepared {
			add {
				this.AddSignalHandler ("area-prepared", value);
			}
			remove {
				this.RemoveSignalHandler ("area-prepared", value);
			}
		}

		static SizePreparedNativeDelegate SizePrepared_cb_delegate;
		static SizePreparedNativeDelegate SizePreparedVMCallback {
			get {
				if (SizePrepared_cb_delegate == null)
					SizePrepared_cb_delegate = new SizePreparedNativeDelegate (SizePrepared_cb);
				return SizePrepared_cb_delegate;
			}
		}

		static void OverrideSizePrepared (GLib.GType gtype)
		{
			OverrideSizePrepared (gtype, SizePreparedVMCallback);
		}

		static void OverrideSizePrepared (GLib.GType gtype, SizePreparedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("size_prepared"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SizePreparedNativeDelegate (IntPtr inst, int width, int height);

		static void SizePrepared_cb (IntPtr inst, int width, int height)
		{
			try {
				PixbufLoader __obj = GLib.Object.GetObject (inst, false) as PixbufLoader;
				__obj.OnSizePrepared (width, height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.PixbufLoader), ConnectionMethod="OverrideSizePrepared")]
		protected virtual void OnSizePrepared (int width, int height)
		{
			InternalSizePrepared (width, height);
		}

		private void InternalSizePrepared (int width, int height)
		{
			SizePreparedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("size_prepared"));
				unmanaged = (SizePreparedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SizePreparedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, width, height);
		}

		static AreaPreparedNativeDelegate AreaPrepared_cb_delegate;
		static AreaPreparedNativeDelegate AreaPreparedVMCallback {
			get {
				if (AreaPrepared_cb_delegate == null)
					AreaPrepared_cb_delegate = new AreaPreparedNativeDelegate (AreaPrepared_cb);
				return AreaPrepared_cb_delegate;
			}
		}

		static void OverrideAreaPrepared (GLib.GType gtype)
		{
			OverrideAreaPrepared (gtype, AreaPreparedVMCallback);
		}

		static void OverrideAreaPrepared (GLib.GType gtype, AreaPreparedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("area_prepared"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AreaPreparedNativeDelegate (IntPtr inst);

		static void AreaPrepared_cb (IntPtr inst)
		{
			try {
				PixbufLoader __obj = GLib.Object.GetObject (inst, false) as PixbufLoader;
				__obj.OnAreaPrepared ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.PixbufLoader), ConnectionMethod="OverrideAreaPrepared")]
		protected virtual void OnAreaPrepared ()
		{
			InternalAreaPrepared ();
		}

		private void InternalAreaPrepared ()
		{
			AreaPreparedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("area_prepared"));
				unmanaged = (AreaPreparedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AreaPreparedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static AreaUpdatedNativeDelegate AreaUpdated_cb_delegate;
		static AreaUpdatedNativeDelegate AreaUpdatedVMCallback {
			get {
				if (AreaUpdated_cb_delegate == null)
					AreaUpdated_cb_delegate = new AreaUpdatedNativeDelegate (AreaUpdated_cb);
				return AreaUpdated_cb_delegate;
			}
		}

		static void OverrideAreaUpdated (GLib.GType gtype)
		{
			OverrideAreaUpdated (gtype, AreaUpdatedVMCallback);
		}

		static void OverrideAreaUpdated (GLib.GType gtype, AreaUpdatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("area_updated"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AreaUpdatedNativeDelegate (IntPtr inst, int x, int y, int width, int height);

		static void AreaUpdated_cb (IntPtr inst, int x, int y, int width, int height)
		{
			try {
				PixbufLoader __obj = GLib.Object.GetObject (inst, false) as PixbufLoader;
				__obj.OnAreaUpdated (x, y, width, height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.PixbufLoader), ConnectionMethod="OverrideAreaUpdated")]
		protected virtual void OnAreaUpdated (int x, int y, int width, int height)
		{
			InternalAreaUpdated (x, y, width, height);
		}

		private void InternalAreaUpdated (int x, int y, int width, int height)
		{
			AreaUpdatedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("area_updated"));
				unmanaged = (AreaUpdatedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AreaUpdatedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, x, y, width, height);
		}

		static ClosedNativeDelegate Closed_cb_delegate;
		static ClosedNativeDelegate ClosedVMCallback {
			get {
				if (Closed_cb_delegate == null)
					Closed_cb_delegate = new ClosedNativeDelegate (Closed_cb);
				return Closed_cb_delegate;
			}
		}

		static void OverrideClosed (GLib.GType gtype)
		{
			OverrideClosed (gtype, ClosedVMCallback);
		}

		static void OverrideClosed (GLib.GType gtype, ClosedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("closed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ClosedNativeDelegate (IntPtr inst);

		static void Closed_cb (IntPtr inst)
		{
			try {
				PixbufLoader __obj = GLib.Object.GetObject (inst, false) as PixbufLoader;
				__obj.OnClosed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.PixbufLoader), ConnectionMethod="OverrideClosed")]
		protected virtual void OnClosed ()
		{
			InternalClosed ();
		}

		private void InternalClosed ()
		{
			ClosedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("closed"));
				unmanaged = (ClosedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ClosedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("size_prepared"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // size_prepared
							, null
							, "area_prepared"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("area_prepared"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // area_prepared
							, "size_prepared"
							, "area_updated"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("area_updated"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // area_updated
							, "area_prepared"
							, "closed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("closed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // closed
							, "area_updated"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gdk_pixbuf_loader_close(IntPtr raw, out IntPtr error);

		public unsafe bool Close() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gdk_pixbuf_loader_close(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_loader_get_animation(IntPtr raw);

		public Gdk.PixbufAnimation Animation { 
			get {
				IntPtr raw_ret = gdk_pixbuf_loader_get_animation(Handle);
				Gdk.PixbufAnimation ret = GLib.Object.GetObject(raw_ret) as Gdk.PixbufAnimation;
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_loader_get_format(IntPtr raw);

		public Gdk.PixbufFormat Format { 
			get {
				IntPtr raw_ret = gdk_pixbuf_loader_get_format(Handle);
				Gdk.PixbufFormat ret = raw_ret == IntPtr.Zero ? null : (Gdk.PixbufFormat) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.PixbufFormat), false);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_loader_get_pixbuf(IntPtr raw);

		public Gdk.Pixbuf Pixbuf { 
			get {
				IntPtr raw_ret = gdk_pixbuf_loader_get_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_loader_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_loader_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_pixbuf_loader_set_size(IntPtr raw, int width, int height);

		public void SetSize(int width, int height) {
			gdk_pixbuf_loader_set_size(Handle, width, height);
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gdk_pixbuf_loader_write(IntPtr raw, byte[] buf, UIntPtr count, out IntPtr error);

		public unsafe bool Write(byte[] buf, ulong count) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gdk_pixbuf_loader_write(Handle, buf, new UIntPtr (count), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gdk_pixbuf_loader_write_bytes(IntPtr raw, IntPtr buffer, out IntPtr error);

		public unsafe bool WriteBytes(GLib.Bytes buffer) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gdk_pixbuf_loader_write_bytes(Handle, buffer == null ? IntPtr.Zero : buffer.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
