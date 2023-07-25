using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using UnityEngine;
using System.Threading.Tasks;
using System;
using UnityEngine.Networking;

public static class HTTPHelpers
{

    public static async void PostWithDigestAuth(string url, string username = "admin", string password = "password", params KeyValuePair<string, string>[] data)
    {
        var handler = new HttpClientHandler()
        {
            Credentials = new NetworkCredential(username, password)
        };
        var httpClient = new HttpClient(handler);
        var formContent = new FormUrlEncodedContent(data);

        var response = await httpClient.PostAsync(url, formContent);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Debug.Log(content);
    }

    public static async Task<string> GetWithDigestAuth(string url, string userName = "admin", string password = "password")
    {
        var handler = new HttpClientHandler()
        {
            Credentials = new NetworkCredential(userName, password)
        };
        var httpClient = new HttpClient(handler);

        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }

    public static async void DeleteWithDigestAuth(string url, string username = "admin", string password = "password")
    {
        var handler = new HttpClientHandler()
        {
            Credentials = new NetworkCredential(username, password)
        };
        var httpClient = new HttpClient(handler);

        var response = await httpClient.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Debug.Log(content);
    }
}
