#if !UNITY_WSA
// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace Cysharp.Net.Http
{
    internal static unsafe partial class NativeMethods
    {
#if UNITY_IOS && !UNITY_EDITOR
        const string __DllName = "__Internal";
#else
        const string __DllName = "Cysharp.Net.Http.YetAnotherHttpHandler.Native";
#endif
        



        [DllImport(__DllName, EntryPoint = "yaha_get_last_error", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* yaha_get_last_error();

        [DllImport(__DllName, EntryPoint = "yaha_free_byte_buffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_free_byte_buffer(ByteBuffer* s);

        [DllImport(__DllName, EntryPoint = "yaha_init_runtime", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern YahaNativeRuntimeContext* yaha_init_runtime();

        [DllImport(__DllName, EntryPoint = "yaha_dispose_runtime", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_dispose_runtime(YahaNativeRuntimeContext* ctx);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void yaha_init_context_on_status_code_and_headers_receive_delegate(int req_seq, nint state, int status_code, YahaHttpVersion version);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void yaha_init_context_on_receive_delegate(int req_seq, nint state, nuint length, byte* buf);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void yaha_init_context_on_complete_delegate(int req_seq, nint state, CompletionReason reason, uint h2_error_code);

        [DllImport(__DllName, EntryPoint = "yaha_init_context", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern YahaNativeContext* yaha_init_context(YahaNativeRuntimeContext* runtime_ctx, yaha_init_context_on_status_code_and_headers_receive_delegate on_status_code_and_headers_receive, yaha_init_context_on_receive_delegate on_receive, yaha_init_context_on_complete_delegate on_complete);

        [DllImport(__DllName, EntryPoint = "yaha_dispose_context", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_dispose_context(YahaNativeContext* ctx);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_add_root_certificates", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint yaha_client_config_add_root_certificates(YahaNativeContext* ctx, StringBuffer* root_certs);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_add_override_server_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_add_override_server_name(YahaNativeContext* ctx, StringBuffer* override_server_name);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_add_client_auth_certificates", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint yaha_client_config_add_client_auth_certificates(YahaNativeContext* ctx, StringBuffer* auth_certs);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_add_client_auth_key", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint yaha_client_config_add_client_auth_key(YahaNativeContext* ctx, StringBuffer* auth_key);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_skip_certificate_verification", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_skip_certificate_verification(YahaNativeContext* ctx, [MarshalAs(UnmanagedType.U1)] bool val);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool yaha_client_config_set_server_certificate_verification_handler_handler_delegate(nint state, byte* server_name, nuint server_name_len, byte* certificate_der, nuint certificate_der_len, ulong now);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_set_server_certificate_verification_handler", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_set_server_certificate_verification_handler(YahaNativeContext* ctx, yaha_client_config_set_server_certificate_verification_handler_handler_delegate handler, nint callback_state);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_pool_idle_timeout", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_pool_idle_timeout(YahaNativeContext* ctx, ulong val_milliseconds);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_pool_max_idle_per_host", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_pool_max_idle_per_host(YahaNativeContext* ctx, nuint max_idle);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_only", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_only(YahaNativeContext* ctx, [MarshalAs(UnmanagedType.U1)] bool val);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_initial_stream_window_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_initial_stream_window_size(YahaNativeContext* ctx, uint val);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_initial_connection_window_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_initial_connection_window_size(YahaNativeContext* ctx, uint val);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_adaptive_window", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_adaptive_window(YahaNativeContext* ctx, [MarshalAs(UnmanagedType.U1)] bool val);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_max_frame_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_max_frame_size(YahaNativeContext* ctx, uint val);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_keep_alive_interval", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_keep_alive_interval(YahaNativeContext* ctx, ulong interval_milliseconds);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_keep_alive_timeout", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_keep_alive_timeout(YahaNativeContext* ctx, ulong timeout_milliseconds);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_keep_alive_while_idle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_keep_alive_while_idle(YahaNativeContext* ctx, [MarshalAs(UnmanagedType.U1)] bool val);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_connect_timeout", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_connect_timeout(YahaNativeContext* ctx, ulong timeout_milliseconds);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_max_concurrent_reset_streams", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_max_concurrent_reset_streams(YahaNativeContext* ctx, nuint max);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_max_send_buf_size", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_max_send_buf_size(YahaNativeContext* ctx, nuint max);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_http2_initial_max_send_streams", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_http2_initial_max_send_streams(YahaNativeContext* ctx, nuint initial);

        [DllImport(__DllName, EntryPoint = "yaha_client_config_unix_domain_socket_path", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_client_config_unix_domain_socket_path(YahaNativeContext* ctx, StringBuffer* uds_path);

        [DllImport(__DllName, EntryPoint = "yaha_build_client", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_build_client(YahaNativeContext* ctx);

        [DllImport(__DllName, EntryPoint = "yaha_request_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern YahaNativeRequestContext* yaha_request_new(YahaNativeContext* ctx, int seq);

        [DllImport(__DllName, EntryPoint = "yaha_request_set_method", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_set_method(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, StringBuffer* value);

        [DllImport(__DllName, EntryPoint = "yaha_request_set_has_body", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_set_has_body(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, [MarshalAs(UnmanagedType.U1)] bool value);

        [DllImport(__DllName, EntryPoint = "yaha_request_set_uri", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_set_uri(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, StringBuffer* value);

        [DllImport(__DllName, EntryPoint = "yaha_request_set_version", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_set_version(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, YahaHttpVersion value);

        [DllImport(__DllName, EntryPoint = "yaha_request_set_header", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_set_header(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, StringBuffer* key, StringBuffer* value);

        [DllImport(__DllName, EntryPoint = "yaha_request_begin", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_begin(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, nint state);

        [DllImport(__DllName, EntryPoint = "yaha_request_abort", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void yaha_request_abort(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx);

        [DllImport(__DllName, EntryPoint = "yaha_request_write_body", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern WriteResult yaha_request_write_body(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, byte* buf, nuint len);

        [DllImport(__DllName, EntryPoint = "yaha_request_complete_body", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_complete_body(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx);

        [DllImport(__DllName, EntryPoint = "yaha_request_response_get_headers_count", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int yaha_request_response_get_headers_count(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx);

        [DllImport(__DllName, EntryPoint = "yaha_request_response_get_header_key", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* yaha_request_response_get_header_key(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, int index);

        [DllImport(__DllName, EntryPoint = "yaha_request_response_get_header_value", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* yaha_request_response_get_header_value(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, int index);

        [DllImport(__DllName, EntryPoint = "yaha_request_response_get_trailers_count", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int yaha_request_response_get_trailers_count(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx);

        [DllImport(__DllName, EntryPoint = "yaha_request_response_get_trailers_key", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* yaha_request_response_get_trailers_key(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, int index);

        [DllImport(__DllName, EntryPoint = "yaha_request_response_get_trailers_value", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* yaha_request_response_get_trailers_value(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx, int index);

        [DllImport(__DllName, EntryPoint = "yaha_request_destroy", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool yaha_request_destroy(YahaNativeContext* ctx, YahaNativeRequestContext* req_ctx);


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct StringBuffer
    {
        public byte* ptr;
        public int length;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ByteBuffer
    {
        public byte* ptr;
        public int length;
        public int capacity;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct YahaNativeRuntimeContext
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct YahaNativeContext
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct YahaNativeRequestContext
    {
    }


    internal enum YahaHttpVersion : int
    {
        Http09,
        Http10,
        Http11,
        Http2,
        Http3,
    }

    internal enum CompletionReason : int
    {
        Success,
        Error,
        Aborted,
    }

    internal enum WriteResult : int
    {
        Success,
        Full,
        AlreadyCompleted,
    }


}
#endif