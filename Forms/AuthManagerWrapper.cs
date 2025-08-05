using System;
using System.Runtime.InteropServices;

public static class AuthManagerWrapper
{
    private const string DllName = "CSharp-Library.dll";

    // Configuration
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void AuthManager_SetConfig(
        [MarshalAs(UnmanagedType.LPStr)] string appName,
        [MarshalAs(UnmanagedType.LPStr)] string ownerId,
        [MarshalAs(UnmanagedType.LPStr)] string appSecret);

    // Core authentication functions
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_CheckAppExists(
        [MarshalAs(UnmanagedType.LPStr)] string appName,
        [MarshalAs(UnmanagedType.LPStr)] string ownerId,
        [MarshalAs(UnmanagedType.LPStr)] string appSecret);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_CheckUserExists(
        [MarshalAs(UnmanagedType.LPStr)] string username,
        [MarshalAs(UnmanagedType.LPStr)] string password,
        [MarshalAs(UnmanagedType.LPStr)] string ownerId);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_CheckLicense(
        [MarshalAs(UnmanagedType.LPStr)] string license,
        [MarshalAs(UnmanagedType.LPStr)] string hwid,
        [MarshalAs(UnmanagedType.LPStr)] string ownerId);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_RegisterUser(
        [MarshalAs(UnmanagedType.LPStr)] string username,
        [MarshalAs(UnmanagedType.LPStr)] string password,
        [MarshalAs(UnmanagedType.LPStr)] string license,
        [MarshalAs(UnmanagedType.LPStr)] string hwid,
        [MarshalAs(UnmanagedType.LPStr)] string ownerId);

    // Utility functions
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_ValidateInput(
        [MarshalAs(UnmanagedType.LPStr)] string username,
        [MarshalAs(UnmanagedType.LPStr)] string password);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static extern string AuthManager_GetHWID();

    // Wrapper for GetHWID to handle string marshaling
    public static string GetHWID()
    {
        return AuthManager_GetHWID() ?? "";
    }

    // Authentication interface
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_Login();

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_License();

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_Register();

    // High-level interface functions for client applications
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_LoginInterface();

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_LicenseInterface();

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)]
    public static extern bool AuthManager_RegisterInterface();
}