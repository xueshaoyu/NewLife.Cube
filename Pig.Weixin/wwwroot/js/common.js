var baseUrl = "http://wx.ourpigs.com";
var appid = "wx953d49201b30ee16";
var AccessToken = "0000";
//获取url的参数
function QueryString(item) {
    var sValue = window.location.search.match(new RegExp("[\?\&]" + item + "=([^\&]*)(\&?)", "i"));
    return sValue ? sValue[1] : sValue;
}
function CheckAuth() {
    var code = QueryString("code");//获取code
    if (code != null && code != "") {//判断code是否存在
        //通过code获取openid 和vid
        $.ajax({
            type: "post",
            url: baseUrl+ "/api/OpenId",
            data: {
                "code": code,
                "date": new Date().getMilliseconds()
            },
            async: false,
            success: function (data) {
                if (data.isSuccess) {
                    //获取成功
                    setCookie("openid", data.data.openid, "d1008");
                   // var redirect = "/index.html?openid=" + getCookie("openid");
                   // window.location.href = redirect;
                } else {
                    delCookie("openid");
                }
            }
        });
    } else {
        var redirect = window.location.href;// url + '/index.html?index=' + index;//首页
        window.location.href = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appid + "&redirect_uri=" + encodeURI(redirect) + "&response_type=code&scope=snsapi_userinfo&state=123#wechat_redirect";
    }
}
function getCookie(name) {//获取Cookie值
    var strCookie = document.cookie;
    var arrCookie = strCookie.split("; ");
    for (var i = 0; i < arrCookie.length; i++) {
        var arr = arrCookie[i].split("=");
        if (arr[0] == name) return decodeURIComponent(arr[1]);
    }
    return null;
}
function setCookie(name, value, time) {//设置Cookie
    if (!time) { time = "h1"; }
    var strsec = getsec(time);
    var exp = new Date();
    exp.setTime(exp.getTime() + strsec * 1);
    document.cookie = name + "=" + decodeURI(value) + ";expires=" + exp.toGMTString();
}
function delCookie(name) {//删除Cookie
    var exp = new Date();
    exp.setTime(exp.getTime() - 1);
    var cval = getCookie(name);
    if (cval != null) document.cookie = name + "=" + cval + ";expires=" + exp.toGMTString();
}
function getsec(str) {//获取时间

    var str1 = str.substring(1, str.length) * 1;
    var str2 = str.substring(0, 1);
    if (str2 == "s") {
        return str1 * 1000;
    } else if (str2 == "h") {
        return str1 * 60 * 60 * 1000;
    } else if (str2 == "d") {
        return str1 * 24 * 60 * 60 * 1000;
    }
}
function GetVidByOpenId(openid) {
    //获取绑定的设备列表
    var vid = [];
    $.ajax({
        type: "get",
        url: "ashx/GetVidByOpenId.ashx",
        data: {
            "openid": openid
        },
        async: false,
        success: function (data) {
            if (data != "0" && data && data.length > 0) {
                vid = data.split(",");
                setCookie("vids", data);
                setCookie("currentVid", vid[0], "d1008");
            } else {
                delCookie("vids");
            }
        }
    });
    return vid;
}
function CheckOpenIdAndCurrentVid() {
    var openId = getCookie("openid");
    if (openId == null || openId == "") {
        CheckAuth();
        return;
    }
}

CheckOpenIdAndCurrentVid();

