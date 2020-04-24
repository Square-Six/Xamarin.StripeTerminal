using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Common.Value.Qual {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='EnsuresMinLenIf']"
	[Register ("org/checkerframework/common/value/qual/EnsuresMinLenIf", "", "Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIfInvoker")]
	public partial interface IEnsuresMinLenIf : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='EnsuresMinLenIf']/method[@name='expression' and count(parameter)=0]"
		[Register ("expression", "()[Ljava/lang/String;", "GetExpressionHandler:Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIfInvoker, Xamarin.Stripe.Terminal.Android")]
		string[] Expression ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='EnsuresMinLenIf']/method[@name='result' and count(parameter)=0]"
		[Register ("result", "()Z", "GetResultHandler:Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIfInvoker, Xamarin.Stripe.Terminal.Android")]
		bool Result ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.common.value.qual']/interface[@name='EnsuresMinLenIf']/method[@name='targetValue' and count(parameter)=0]"
		[Register ("targetValue", "()I", "GetTargetValueHandler:Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIfInvoker, Xamarin.Stripe.Terminal.Android")]
		int TargetValue ();

	}

	[global::Android.Runtime.Register ("org/checkerframework/common/value/qual/EnsuresMinLenIf", DoNotGenerateAcw=true)]
	internal partial class IEnsuresMinLenIfInvoker : global::Java.Lang.Object, IEnsuresMinLenIf {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/common/value/qual/EnsuresMinLenIf", typeof (IEnsuresMinLenIfInvoker));

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

		public static IEnsuresMinLenIf GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEnsuresMinLenIf> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.checkerframework.common.value.qual.EnsuresMinLenIf"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEnsuresMinLenIfInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_expression;
#pragma warning disable 0169
		static Delegate GetExpressionHandler ()
		{
			if (cb_expression == null)
				cb_expression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Expression);
			return cb_expression;
		}

		static IntPtr n_Expression (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Expression ());
		}
#pragma warning restore 0169

		IntPtr id_expression;
		public unsafe string[] Expression ()
		{
			if (id_expression == IntPtr.Zero)
				id_expression = JNIEnv.GetMethodID (class_ref, "expression", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_expression), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_result;
#pragma warning disable 0169
		static Delegate GetResultHandler ()
		{
			if (cb_result == null)
				cb_result = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Result);
			return cb_result;
		}

		static bool n_Result (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Result ();
		}
#pragma warning restore 0169

		IntPtr id_result;
		public unsafe bool Result ()
		{
			if (id_result == IntPtr.Zero)
				id_result = JNIEnv.GetMethodID (class_ref, "result", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_result);
		}

		static Delegate cb_targetValue;
#pragma warning disable 0169
		static Delegate GetTargetValueHandler ()
		{
			if (cb_targetValue == null)
				cb_targetValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TargetValue);
			return cb_targetValue;
		}

		static int n_TargetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetValue ();
		}
#pragma warning restore 0169

		IntPtr id_targetValue;
		public unsafe int TargetValue ()
		{
			if (id_targetValue == IntPtr.Zero)
				id_targetValue = JNIEnv.GetMethodID (class_ref, "targetValue", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_targetValue);
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
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf __this = global::Java.Lang.Object.GetObject<global::Org.Checkerframework.Common.Value.Qual.IEnsuresMinLenIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
