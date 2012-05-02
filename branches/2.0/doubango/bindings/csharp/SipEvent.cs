/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class SipEvent : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipEvent(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SipEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_SipEvent(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public short getCode() {
    short ret = tinyWRAPPINVOKE.SipEvent_getCode(swigCPtr);
    return ret;
  }

  public string getPhrase() {
    string ret = tinyWRAPPINVOKE.SipEvent_getPhrase(swigCPtr);
    return ret;
  }

  public SipSession getBaseSession() {
    IntPtr cPtr = tinyWRAPPINVOKE.SipEvent_getBaseSession(swigCPtr);
    SipSession ret = (cPtr == IntPtr.Zero) ? null : new SipSession(cPtr, false);
    return ret;
  }

  public SipMessage getSipMessage() {
    IntPtr cPtr = tinyWRAPPINVOKE.SipEvent_getSipMessage(swigCPtr);
    SipMessage ret = (cPtr == IntPtr.Zero) ? null : new SipMessage(cPtr, false);
    return ret;
  }

}

}
