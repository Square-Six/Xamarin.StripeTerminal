using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Javax.Annotation {

	// Metadata.xml XPath class reference: path="/api/package[@name='javax.annotation']/class[@name='Nonnull.Checker']"
	[global::Android.Runtime.Register ("javax/annotation/Nonnull$Checker", DoNotGenerateAcw=true)]
	public partial class NonnullChecker : global::Java.Lang.Object, global::Javax.Annotation.Meta.ITypeQualifierValidator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("javax/annotation/Nonnull$Checker", typeof (NonnullChecker));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected NonnullChecker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='javax.annotation']/class[@name='Nonnull.Checker']/constructor[@name='Nonnull.Checker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NonnullChecker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_forConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetForConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_Handler ()
		{
			if (cb_forConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_ == null)
				cb_forConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ForConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_);
			return cb_forConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_;
		}

		static IntPtr n_ForConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_qualifierArgument, IntPtr native_value)
		{
			global::Javax.Annotation.NonnullChecker __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.NonnullChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Annotation.INonnull qualifierArgument = (global::Javax.Annotation.INonnull)global::Java.Lang.Object.GetObject<global::Javax.Annotation.INonnull> (native_qualifierArgument, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForConstantValue (qualifierArgument, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='javax.annotation']/class[@name='Nonnull.Checker']/method[@name='forConstantValue' and count(parameter)=2 and parameter[1][@type='javax.annotation.Nonnull'] and parameter[2][@type='java.lang.Object']]"
		[Register ("forConstantValue", "(Ljavax/annotation/Nonnull;Ljava/lang/Object;)Ljavax/annotation/meta/When;", "GetForConstantValue_Ljavax_annotation_Nonnull_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Javax.Annotation.Meta.When ForConstantValue (global::Javax.Annotation.INonnull qualifierArgument, global::Java.Lang.Object value)
		{
			const string __id = "forConstantValue.(Ljavax/annotation/Nonnull;Ljava/lang/Object;)Ljavax/annotation/meta/When;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((qualifierArgument == null) ? IntPtr.Zero : ((global::Java.Lang.Object) qualifierArgument).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Javax.Annotation.Meta.ITypeQualifierValidator
		global::Javax.Annotation.Meta.When global::Javax.Annotation.Meta.ITypeQualifierValidator.ForConstantValue (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			return ForConstantValue (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Javax.Annotation.INonnull>(p0), p1);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='javax.annotation']/interface[@name='Nonnull']"
	[Register ("javax/annotation/Nonnull", "", "Javax.Annotation.INonnullInvoker")]
	public partial interface INonnull : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='javax.annotation']/interface[@name='Nonnull']/method[@name='when' and count(parameter)=0]"
		[Register ("when", "()Ljavax/annotation/meta/When;", "GetWhenHandler:Javax.Annotation.INonnullInvoker, Xamarin.Stripe.Terminal.Android")]
		global::Javax.Annotation.Meta.When When ();

	}

	[global::Android.Runtime.Register ("javax/annotation/Nonnull", DoNotGenerateAcw=true)]
	internal partial class INonnullInvoker : global::Java.Lang.Object, INonnull {

		static readonly JniPeerMembers _members = new XAPeerMembers ("javax/annotation/Nonnull", typeof (INonnullInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static INonnull GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INonnull> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "javax.annotation.Nonnull"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INonnullInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_when;
#pragma warning disable 0169
		static Delegate GetWhenHandler ()
		{
			if (cb_when == null)
				cb_when = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_When);
			return cb_when;
		}

		static IntPtr n_When (IntPtr jnienv, IntPtr native__this)
		{
			global::Javax.Annotation.INonnull __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.INonnull> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.When ());
		}
#pragma warning restore 0169

		IntPtr id_when;
		public unsafe global::Javax.Annotation.Meta.When When ()
		{
			if (id_when == IntPtr.Zero)
				id_when = JNIEnv.GetMethodID (class_ref, "when", "()Ljavax/annotation/meta/When;");
			return global::Java.Lang.Object.GetObject<global::Javax.Annotation.Meta.When> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_when), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Javax.Annotation.INonnull __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.INonnull> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Javax.Annotation.INonnull __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.INonnull> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Javax.Annotation.INonnull __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.INonnull> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Javax.Annotation.INonnull __this = global::Java.Lang.Object.GetObject<global::Javax.Annotation.INonnull> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
