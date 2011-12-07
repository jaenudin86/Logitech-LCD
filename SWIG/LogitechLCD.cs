/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class LogitechLCD {
  public static uint lgLcdInit() {
    uint ret = LogitechLCDPINVOKE.lgLcdInit();
    return ret;
  }

  public static uint lgLcdDeInit() {
    uint ret = LogitechLCDPINVOKE.lgLcdDeInit();
    return ret;
  }

  public static uint lgLcdConnectW(lgLcdConnectContextW ctx) {
    uint ret = LogitechLCDPINVOKE.lgLcdConnectW(lgLcdConnectContextW.getCPtr(ctx));
    return ret;
  }

  public static uint lgLcdConnectA(lgLcdConnectContextA ctx) {
    uint ret = LogitechLCDPINVOKE.lgLcdConnectA(lgLcdConnectContextA.getCPtr(ctx));
    return ret;
  }

  public static uint lgLcdConnectExW(lgLcdConnectContextExW ctx) {
    uint ret = LogitechLCDPINVOKE.lgLcdConnectExW(lgLcdConnectContextExW.getCPtr(ctx));
    return ret;
  }

  public static uint lgLcdConnectExA(lgLcdConnectContextExA ctx) {
    uint ret = LogitechLCDPINVOKE.lgLcdConnectExA(lgLcdConnectContextExA.getCPtr(ctx));
    return ret;
  }

  public static uint lgLcdDisconnect(int connection) {
    uint ret = LogitechLCDPINVOKE.lgLcdDisconnect(connection);
    return ret;
  }

  public static uint lgLcdSetDeviceFamiliesToUse(int connection, uint dwDeviceFamiliesSupported, uint dwReserved1) {
    uint ret = LogitechLCDPINVOKE.lgLcdSetDeviceFamiliesToUse(connection, dwDeviceFamiliesSupported, dwReserved1);
    return ret;
  }

  public static uint lgLcdEnumerate(int connection, int index, lgLcdDeviceDesc description) {
    uint ret = LogitechLCDPINVOKE.lgLcdEnumerate(connection, index, lgLcdDeviceDesc.getCPtr(description));
    return ret;
  }

  public static uint lgLcdEnumerateExW(int connection, int index, lgLcdDeviceDescExW description) {
    uint ret = LogitechLCDPINVOKE.lgLcdEnumerateExW(connection, index, lgLcdDeviceDescExW.getCPtr(description));
    return ret;
  }

  public static uint lgLcdEnumerateExA(int connection, int index, lgLcdDeviceDescExA description) {
    uint ret = LogitechLCDPINVOKE.lgLcdEnumerateExA(connection, index, lgLcdDeviceDescExA.getCPtr(description));
    return ret;
  }

  public static uint lgLcdOpen(lgLcdOpenContext ctx) {
    uint ret = LogitechLCDPINVOKE.lgLcdOpen(lgLcdOpenContext.getCPtr(ctx));
    return ret;
  }

  public static uint lgLcdOpenByType(lgLcdOpenByTypeContext ctx) {
    uint ret = LogitechLCDPINVOKE.lgLcdOpenByType(lgLcdOpenByTypeContext.getCPtr(ctx));
    return ret;
  }

  public static uint lgLcdClose(int device) {
    uint ret = LogitechLCDPINVOKE.lgLcdClose(device);
    return ret;
  }

  public static uint lgLcdReadSoftButtons(int device, SWIGTYPE_p_unsigned_long buttons) {
    uint ret = LogitechLCDPINVOKE.lgLcdReadSoftButtons(device, SWIGTYPE_p_unsigned_long.getCPtr(buttons));
    return ret;
  }

  public static uint lgLcdUpdateBitmap(int device, lgLcdBitmapHeader bitmap, uint priority) {
    uint ret = LogitechLCDPINVOKE.lgLcdUpdateBitmap(device, lgLcdBitmapHeader.getCPtr(bitmap), priority);
    return ret;
  }

  public static uint lgLcdSetAsLCDForegroundApp(int device, int foregroundYesNoFlag) {
    uint ret = LogitechLCDPINVOKE.lgLcdSetAsLCDForegroundApp(device, foregroundYesNoFlag);
    return ret;
  }

  public static readonly int LGLCD_INVALID_CONNECTION = LogitechLCDPINVOKE.LGLCD_INVALID_CONNECTION_get();
  public static readonly int LGLCD_INVALID_DEVICE = LogitechLCDPINVOKE.LGLCD_INVALID_DEVICE_get();
  public static readonly int LGLCDBUTTON_LEFT = LogitechLCDPINVOKE.LGLCDBUTTON_LEFT_get();
  public static readonly int LGLCDBUTTON_RIGHT = LogitechLCDPINVOKE.LGLCDBUTTON_RIGHT_get();
  public static readonly int LGLCDBUTTON_OK = LogitechLCDPINVOKE.LGLCDBUTTON_OK_get();
  public static readonly int LGLCDBUTTON_CANCEL = LogitechLCDPINVOKE.LGLCDBUTTON_CANCEL_get();
  public static readonly int LGLCDBUTTON_UP = LogitechLCDPINVOKE.LGLCDBUTTON_UP_get();
  public static readonly int LGLCDBUTTON_DOWN = LogitechLCDPINVOKE.LGLCDBUTTON_DOWN_get();
  public static readonly int LGLCDBUTTON_MENU = LogitechLCDPINVOKE.LGLCDBUTTON_MENU_get();
  public static readonly int LGLCDBUTTON_BUTTON0 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON0_get();
  public static readonly int LGLCDBUTTON_BUTTON1 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON1_get();
  public static readonly int LGLCDBUTTON_BUTTON2 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON2_get();
  public static readonly int LGLCDBUTTON_BUTTON3 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON3_get();
  public static readonly int LGLCDBUTTON_BUTTON4 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON4_get();
  public static readonly int LGLCDBUTTON_BUTTON5 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON5_get();
  public static readonly int LGLCDBUTTON_BUTTON6 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON6_get();
  public static readonly int LGLCDBUTTON_BUTTON7 = LogitechLCDPINVOKE.LGLCDBUTTON_BUTTON7_get();
  public static readonly int LGLCD_BMP_FORMAT_160x43x1 = LogitechLCDPINVOKE.LGLCD_BMP_FORMAT_160x43x1_get();
  public static readonly int LGLCD_BMP_FORMAT_QVGAx32 = LogitechLCDPINVOKE.LGLCD_BMP_FORMAT_QVGAx32_get();
  public static readonly int LGLCD_BMP_WIDTH = LogitechLCDPINVOKE.LGLCD_BMP_WIDTH_get();
  public static readonly int LGLCD_BMP_HEIGHT = LogitechLCDPINVOKE.LGLCD_BMP_HEIGHT_get();
  public static readonly int LGLCD_BMP_BPP = LogitechLCDPINVOKE.LGLCD_BMP_BPP_get();
  public static readonly int LGLCD_BW_BMP_WIDTH = LogitechLCDPINVOKE.LGLCD_BW_BMP_WIDTH_get();
  public static readonly int LGLCD_BW_BMP_HEIGHT = LogitechLCDPINVOKE.LGLCD_BW_BMP_HEIGHT_get();
  public static readonly int LGLCD_BW_BMP_BPP = LogitechLCDPINVOKE.LGLCD_BW_BMP_BPP_get();
  public static readonly int LGLCD_QVGA_BMP_WIDTH = LogitechLCDPINVOKE.LGLCD_QVGA_BMP_WIDTH_get();
  public static readonly int LGLCD_QVGA_BMP_HEIGHT = LogitechLCDPINVOKE.LGLCD_QVGA_BMP_HEIGHT_get();
  public static readonly int LGLCD_QVGA_BMP_BPP = LogitechLCDPINVOKE.LGLCD_QVGA_BMP_BPP_get();
  public static readonly int LGLCD_PRIORITY_IDLE_NO_SHOW = LogitechLCDPINVOKE.LGLCD_PRIORITY_IDLE_NO_SHOW_get();
  public static readonly int LGLCD_PRIORITY_BACKGROUND = LogitechLCDPINVOKE.LGLCD_PRIORITY_BACKGROUND_get();
  public static readonly int LGLCD_PRIORITY_NORMAL = LogitechLCDPINVOKE.LGLCD_PRIORITY_NORMAL_get();
  public static readonly int LGLCD_PRIORITY_ALERT = LogitechLCDPINVOKE.LGLCD_PRIORITY_ALERT_get();
  public static readonly int LGLCD_LCD_FOREGROUND_APP_NO = LogitechLCDPINVOKE.LGLCD_LCD_FOREGROUND_APP_NO_get();
  public static readonly int LGLCD_LCD_FOREGROUND_APP_YES = LogitechLCDPINVOKE.LGLCD_LCD_FOREGROUND_APP_YES_get();
  public static readonly int LGLCD_DEVICE_FAMILY_BW_160x43_GAMING = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_BW_160x43_GAMING_get();
  public static readonly int LGLCD_DEVICE_FAMILY_KEYBOARD_G15 = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_KEYBOARD_G15_get();
  public static readonly int LGLCD_DEVICE_FAMILY_BW_160x43_AUDIO = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_BW_160x43_AUDIO_get();
  public static readonly int LGLCD_DEVICE_FAMILY_SPEAKERS_Z10 = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_SPEAKERS_Z10_get();
  public static readonly int LGLCD_DEVICE_FAMILY_JACKBOX = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_JACKBOX_get();
  public static readonly int LGLCD_DEVICE_FAMILY_BW_160x43_BASIC = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_BW_160x43_BASIC_get();
  public static readonly int LGLCD_DEVICE_FAMILY_LCDEMULATOR_G15 = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_LCDEMULATOR_G15_get();
  public static readonly int LGLCD_DEVICE_FAMILY_RAINBOW = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_RAINBOW_get();
  public static readonly int LGLCD_DEVICE_FAMILY_QVGA_BASIC = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_QVGA_BASIC_get();
  public static readonly int LGLCD_DEVICE_FAMILY_QVGA_GAMING = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_QVGA_GAMING_get();
  public static readonly int LGLCD_DEVICE_FAMILY_GAMEBOARD_G13 = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_GAMEBOARD_G13_get();
  public static readonly int LGLCD_DEVICE_FAMILY_KEYBOARD_G510 = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_KEYBOARD_G510_get();
  public static readonly int LGLCD_DEVICE_FAMILY_OTHER = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_OTHER_get();
  public static readonly int LGLCD_DEVICE_FAMILY_ALL_BW_160x43 = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_ALL_BW_160x43_get();
  public static readonly int LGLCD_DEVICE_FAMILY_ALL_QVGA = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_ALL_QVGA_get();
  public static readonly int LGLCD_DEVICE_FAMILY_ALL = LogitechLCDPINVOKE.LGLCD_DEVICE_FAMILY_ALL_get();
  public static readonly int LGLCD_APPLET_CAP_BASIC = LogitechLCDPINVOKE.LGLCD_APPLET_CAP_BASIC_get();
  public static readonly int LGLCD_APPLET_CAP_BW = LogitechLCDPINVOKE.LGLCD_APPLET_CAP_BW_get();
  public static readonly int LGLCD_APPLET_CAP_QVGA = LogitechLCDPINVOKE.LGLCD_APPLET_CAP_QVGA_get();
  public static readonly int LGLCD_NOTIFICATION_DEVICE_ARRIVAL = LogitechLCDPINVOKE.LGLCD_NOTIFICATION_DEVICE_ARRIVAL_get();
  public static readonly int LGLCD_NOTIFICATION_DEVICE_REMOVAL = LogitechLCDPINVOKE.LGLCD_NOTIFICATION_DEVICE_REMOVAL_get();
  public static readonly int LGLCD_NOTIFICATION_CLOSE_CONNECTION = LogitechLCDPINVOKE.LGLCD_NOTIFICATION_CLOSE_CONNECTION_get();
  public static readonly int LGLCD_NOTIFICATION_APPLET_DISABLED = LogitechLCDPINVOKE.LGLCD_NOTIFICATION_APPLET_DISABLED_get();
  public static readonly int LGLCD_NOTIFICATION_APPLET_ENABLED = LogitechLCDPINVOKE.LGLCD_NOTIFICATION_APPLET_ENABLED_get();
  public static readonly int LGLCD_NOTIFICATION_TERMINATE_APPLET = LogitechLCDPINVOKE.LGLCD_NOTIFICATION_TERMINATE_APPLET_get();
  public static readonly int LGLCD_DEVICE_BW = LogitechLCDPINVOKE.LGLCD_DEVICE_BW_get();
  public static readonly int LGLCD_DEVICE_QVGA = LogitechLCDPINVOKE.LGLCD_DEVICE_QVGA_get();
}
