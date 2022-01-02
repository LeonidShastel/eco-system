using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;

namespace eco_system.Api
{
    internal class ApiRequests
    {
        string host = "192.168.0.101";
        string port = "80";
        
        public async Task<Person[]> GetUsers()
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://"+host + ":" + port + "/users");
                    string content = await response.Content.ReadAsStringAsync();
                    if(response.StatusCode.ToString() == "OK")
                    {
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Person[] peoples = JsonConvert.DeserializeObject<Person[]>(content.Substring(start, length));
                        return peoples;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Person> GetCurrentPerson(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://" + host + ":" + port + "/users/"+id);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Person people = JsonConvert.DeserializeObject<Person>(content.Substring(start, length));
                        return people;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Person> UpdatePerson(Person person)
        {
            
            HttpContent contentResonse = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PutAsync("http://" + host + ":" + port + "/users/" + person.id,contentResonse);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        Debug.WriteLine(content);
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Person people = JsonConvert.DeserializeObject<Person>(content.Substring(start, length));
                        Debug.WriteLine(people.lastname);
                        return people;
                    }
                    Debug.WriteLine(content);
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Person> CreatePerson(Person person)
        {
            HttpContent contentResonse = new StringContent(JsonConvert.SerializeObject(person,
                Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }
                ), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync("http://" + host + ":" + port + "/users/", contentResonse);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        Debug.WriteLine(content);
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Person people = JsonConvert.DeserializeObject<Person>(content.Substring(start, length));
                        Debug.WriteLine(people.lastname);
                        return people;
                    }
                    Debug.WriteLine(content);
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<bool> DeletePerson(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.DeleteAsync("http://" + host + ":" + port + "/users/"+id);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        return content.IndexOf("deleted")>=0;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        public async Task<Call[]> GetCalls()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://" + host + ":" + port + "/government_agencies");
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Call[] calls = JsonConvert.DeserializeObject<Call[]>(content.Substring(start, length));
                        return calls;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Call[]> GetCallsOrganiztion(int number)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://" + host + ":" + port + "/government_agencies/"+number);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Call[] calls = JsonConvert.DeserializeObject<Call[]>(content.Substring(start, length));
                        Debug.WriteLine(calls[0].title);
                        return calls;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Call> GetCurrentCall(int number, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://" + host + ":" + port + "/government_agencies/" + number+"/"+id);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Call call = JsonConvert.DeserializeObject<Call>(content.Substring(start, length));
                        Debug.WriteLine(call.title);
                        return call;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Call> UpdateCall(Call call)
        {

            HttpContent contentResonse = new StringContent(JsonConvert.SerializeObject(call), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PutAsync("http://" + host + ":" + port + "/government_agencies/" + call.id, contentResonse);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        Debug.WriteLine(content);
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Call update_call = JsonConvert.DeserializeObject<Call>(content.Substring(start, length));
                        return update_call;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<Call> CreateCall(Call call)
        {
            HttpContent contentResonse = new StringContent(JsonConvert.SerializeObject(call,
                Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }
                ), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync("http://" + host + ":" + port + "/government_agencies/", contentResonse);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        Debug.WriteLine(content);
                        int start = content.IndexOf("\"data\":") + 7;
                        int length = content.Length - 1 - start;
                        Call new_call = JsonConvert.DeserializeObject<Call>(content.Substring(start, length));
                        return new_call;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public async Task<bool> DeleteCall(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.DeleteAsync("http://" + host + ":" + port + "/government_agencies/" + id);
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        return content.IndexOf("deleted") >= 0;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
