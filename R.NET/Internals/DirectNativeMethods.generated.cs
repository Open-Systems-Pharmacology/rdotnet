﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RDotNet.Internals {
	
	
	internal partial class DirectNativeMethods {
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isLanguage")]
private static extern System.Boolean _Rf_isLanguage(System.IntPtr sexp);
		
		public bool Rf_isLanguage(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isLanguage(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isFunction")]
private static extern System.Boolean _Rf_isFunction(System.IntPtr sexp);
		
		public bool Rf_isFunction(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isFunction(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "R_lsInternal")]
private static extern System.IntPtr _R_lsInternal(System.IntPtr environment, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] System.Boolean all);
		
		public System.IntPtr R_lsInternal(System.IntPtr environment, bool all) {
			return DirectNativeMethods._R_lsInternal(  environment,   all);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_applyClosure")]
private static extern System.IntPtr _Rf_applyClosure(System.IntPtr call, System.IntPtr value, System.IntPtr arguments, System.IntPtr environment, System.IntPtr suppliedEnvironment);
		
		public System.IntPtr Rf_applyClosure(System.IntPtr call, System.IntPtr value, System.IntPtr arguments, System.IntPtr environment, System.IntPtr suppliedEnvironment) {
			return DirectNativeMethods._Rf_applyClosure(  call,   value,   arguments,   environment,   suppliedEnvironment);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_VectorToPairList")]
private static extern System.IntPtr _Rf_VectorToPairList(System.IntPtr sexp);
		
		public System.IntPtr Rf_VectorToPairList(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_VectorToPairList(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_allocSExp")]
private static extern System.IntPtr _Rf_allocSExp(RDotNet.Internals.SymbolicExpressionType type);
		
		public System.IntPtr Rf_allocSExp(RDotNet.Internals.SymbolicExpressionType type) {
			return DirectNativeMethods._Rf_allocSExp(  type);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_cons")]
private static extern System.IntPtr _Rf_cons(System.IntPtr sexp, System.IntPtr next);
		
		public System.IntPtr Rf_cons(System.IntPtr sexp, System.IntPtr next) {
			return DirectNativeMethods._Rf_cons(  sexp,   next);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_lcons")]
private static extern System.IntPtr _Rf_lcons(System.IntPtr sexp, System.IntPtr next);
		
		public System.IntPtr Rf_lcons(System.IntPtr sexp, System.IntPtr next) {
			return DirectNativeMethods._Rf_lcons(  sexp,   next);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_initEmbeddedR")]
private static extern System.Int32 _Rf_initEmbeddedR(System.Int32 argc, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPArray, ArraySubType=System.Runtime.InteropServices.UnmanagedType.LPStr)] System.String[] argv);
		
		public int Rf_initEmbeddedR(int argc, string[] argv) {
			return DirectNativeMethods._Rf_initEmbeddedR(  argc,   argv);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_endEmbeddedR")]
private static extern void _Rf_endEmbeddedR(System.Int32 fatal);
		
		public void Rf_endEmbeddedR(int fatal) {
			DirectNativeMethods._Rf_endEmbeddedR(  fatal);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_protect")]
private static extern System.IntPtr _Rf_protect(System.IntPtr sexp);
		
		public System.IntPtr Rf_protect(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_protect(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_unprotect")]
private static extern void _Rf_unprotect(System.Int32 count);
		
		public void Rf_unprotect(int count) {
			DirectNativeMethods._Rf_unprotect(  count);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_unprotect_ptr")]
private static extern void _Rf_unprotect_ptr(System.IntPtr sexp);
		
		public void Rf_unprotect_ptr(System.IntPtr sexp) {
			DirectNativeMethods._Rf_unprotect_ptr(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_install")]
private static extern System.IntPtr _Rf_install([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] System.String s);
		
		public System.IntPtr Rf_install(string s) {
			return DirectNativeMethods._Rf_install(  s);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_mkString")]
private static extern System.IntPtr _Rf_mkString([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] System.String s);
		
		public System.IntPtr Rf_mkString(string s) {
			return DirectNativeMethods._Rf_mkString(  s);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_mkChar")]
private static extern System.IntPtr _Rf_mkChar([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] System.String s);
		
		public System.IntPtr Rf_mkChar(string s) {
			return DirectNativeMethods._Rf_mkChar(  s);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_allocVector")]
private static extern System.IntPtr _Rf_allocVector(RDotNet.Internals.SymbolicExpressionType type, System.Int32 length);
		
		public System.IntPtr Rf_allocVector(RDotNet.Internals.SymbolicExpressionType type, int length) {
			return DirectNativeMethods._Rf_allocVector(  type,   length);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_coerceVector")]
private static extern System.IntPtr _Rf_coerceVector(System.IntPtr sexp, RDotNet.Internals.SymbolicExpressionType type);
		
		public System.IntPtr Rf_coerceVector(System.IntPtr sexp, RDotNet.Internals.SymbolicExpressionType type) {
			return DirectNativeMethods._Rf_coerceVector(  sexp,   type);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isVector")]
private static extern System.Boolean _Rf_isVector(System.IntPtr sexp);
		
		public bool Rf_isVector(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isVector(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_length")]
private static extern System.Int32 _Rf_length(System.IntPtr sexp);
		
		public int Rf_length(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_length(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_allocMatrix")]
private static extern System.IntPtr _Rf_allocMatrix(RDotNet.Internals.SymbolicExpressionType type, System.Int32 rowCount, System.Int32 columnCount);
		
		public System.IntPtr Rf_allocMatrix(RDotNet.Internals.SymbolicExpressionType type, int rowCount, int columnCount) {
			return DirectNativeMethods._Rf_allocMatrix(  type,   rowCount,   columnCount);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isMatrix")]
private static extern System.Boolean _Rf_isMatrix(System.IntPtr sexp);
		
		public bool Rf_isMatrix(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isMatrix(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_nrows")]
private static extern System.Int32 _Rf_nrows(System.IntPtr sexp);
		
		public int Rf_nrows(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_nrows(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_ncols")]
private static extern System.Int32 _Rf_ncols(System.IntPtr sexp);
		
		public int Rf_ncols(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_ncols(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_allocList")]
private static extern System.IntPtr _Rf_allocList(System.Int32 length);
		
		public System.IntPtr Rf_allocList(int length) {
			return DirectNativeMethods._Rf_allocList(  length);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isList")]
private static extern System.Boolean _Rf_isList(System.IntPtr sexp);
		
		public bool Rf_isList(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isList(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_eval")]
private static extern System.IntPtr _Rf_eval(System.IntPtr statement, System.IntPtr environment);
		
		public System.IntPtr Rf_eval(System.IntPtr statement, System.IntPtr environment) {
			return DirectNativeMethods._Rf_eval(  statement,   environment);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "R_tryEval")]
private static extern System.IntPtr _R_tryEval(System.IntPtr statement, System.IntPtr environment, out System.Boolean errorOccurred);
		
		public System.IntPtr R_tryEval(System.IntPtr statement, System.IntPtr environment, out bool errorOccurred) {
			return DirectNativeMethods._R_tryEval(  statement,   environment, out   errorOccurred);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "R_ParseVector")]
private static extern System.IntPtr _R_ParseVector(System.IntPtr statement, System.Int32 statementCount, out RDotNet.Internals.ParseStatus status, System.IntPtr _);
		
		public System.IntPtr R_ParseVector(System.IntPtr statement, int statementCount, out RDotNet.Internals.ParseStatus status, System.IntPtr _) {
			return DirectNativeMethods._R_ParseVector(  statement,   statementCount, out   status,   _);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_findVar")]
private static extern System.IntPtr _Rf_findVar(System.IntPtr name, System.IntPtr environment);
		
		public System.IntPtr Rf_findVar(System.IntPtr name, System.IntPtr environment) {
			return DirectNativeMethods._Rf_findVar(  name,   environment);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_setVar")]
private static extern void _Rf_setVar(System.IntPtr name, System.IntPtr value, System.IntPtr environment);
		
		public void Rf_setVar(System.IntPtr name, System.IntPtr value, System.IntPtr environment) {
			DirectNativeMethods._Rf_setVar(  name,   value,   environment);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_getAttrib")]
private static extern System.IntPtr _Rf_getAttrib(System.IntPtr sexp, System.IntPtr name);
		
		public System.IntPtr Rf_getAttrib(System.IntPtr sexp, System.IntPtr name) {
			return DirectNativeMethods._Rf_getAttrib(  sexp,   name);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_setAttrib")]
private static extern System.IntPtr _Rf_setAttrib(System.IntPtr sexp, System.IntPtr name, System.IntPtr value);
		
		public System.IntPtr Rf_setAttrib(System.IntPtr sexp, System.IntPtr name, System.IntPtr value) {
			return DirectNativeMethods._Rf_setAttrib(  sexp,   name,   value);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isEnvironment")]
private static extern System.Boolean _Rf_isEnvironment(System.IntPtr sexp);
		
		public bool Rf_isEnvironment(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isEnvironment(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isExpression")]
private static extern System.Boolean _Rf_isExpression(System.IntPtr sexp);
		
		public bool Rf_isExpression(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isExpression(  sexp);
		}
		
[System.Runtime.InteropServices.DllImportAttribute(RDotNet.Internals.Constants.RDllName, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "Rf_isSymbol")]
private static extern System.Boolean _Rf_isSymbol(System.IntPtr sexp);
		
		public bool Rf_isSymbol(System.IntPtr sexp) {
			return DirectNativeMethods._Rf_isSymbol(  sexp);
		}
	}
}
