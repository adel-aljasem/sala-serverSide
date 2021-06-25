using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common
{
    public static class JSRuntimeExtention
    {
        public async static ValueTask ToastrSuccess(this IJSRuntime jSRuntime , string message)
        {
            await jSRuntime.InvokeVoidAsync("toastr.success", message);
        }
        public async static ValueTask ToastrError(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("toastr.error", message);
        }

        public async static ValueTask SweetAlertSuccess(this IJSRuntime jSRuntime,string message)
        {
            await jSRuntime.InvokeVoidAsync("Swal.fire", "نجاح", message, "success");

        }


    }
}
