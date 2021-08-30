using Microsoft.JSInterop;
using BlazorWASM.Service.Model;

namespace BlazorWASM.Service;
public sealed class WindowSizeService
{
	private readonly IJSRuntime _js;

	public WindowSizeService(IJSRuntime js)
	{
		_js = js;
	}

	public async Task<WindowSizeModel> GetSizeWindow()
	{
		return await _js.InvokeAsync<WindowSizeModel>("getWindowSize");
	}
}
