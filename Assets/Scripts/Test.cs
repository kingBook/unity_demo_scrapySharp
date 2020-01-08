using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Network;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Test:MonoBehaviour{
	
	private void Start() {
		
	}
	
	async private void TestUrl(){
		Debug.Log("TestUrl");
		ScrapingBrowser browser = new ScrapingBrowser();
		//以下代码行，会造成死机
		//var text = browser.DownloadString(new Uri("https://www.baidu.com/s?wd=ScrapySharp"));
		//尝试过使用异步，不死机，却爬取不到内容
		var text= await browser.DownloadStringAsync(new Uri("https://www.baidu.com/s?wd=ScrapySharp"));
		Debug.Log(text);
	}
	
	private void Update() {
		if(Input.GetMouseButtonDown(0)){
			TestUrl();
		}
	}
}
