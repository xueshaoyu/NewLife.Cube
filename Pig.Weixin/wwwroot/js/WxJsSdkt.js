
$.ajax({
    type: "get",
    url: '/api/WxJsSdk',
    data: {},
    async: false,
    success: function (data) {
        if (data.isSuccess) {
            data = data.data;
            wx.config({
                debug: false, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
                appId: appid, // 必填，公众号的唯一标识
                timestamp: data.timestamp, // 必填，生成签名的时间戳
                nonceStr: data.nonceStr, // 必填，生成签名的随机串
                signature: data.signature,// 必填，签名
                jsApiList: ['chooseImage', 'uploadImage'] // 必填，需要使用的JS接口列表
            });
        }
    }
});
function delImg(dom) {//多张图片删除处理
    var $addImg = $(dom).parents('.multiImg').parent().next();
    $(dom).parents('.multiImg').remove();
    count++;//每次删除一张图片,count就加1，不用笔者在解释
    $addImg.css("display", "block");
}
var images = {
    localId: [],
    serverId: []
};
var carPicUrl = [];//存放车辆照片的url
var count = 3; //图片的最大数量
var ios = false; //判断是否是ios或者iphone设备
var $imgContainer; //通过Jquery选择器获取的Dom对象作为图片容器
function uploadImage(localIds, imgContainer)
{
    var i = 0, picNum = images.localId.length;
    images.serverId = [];
    function upload() {
        wx.uploadImage({
            localId: localIds[i], // 需要上传的图片的本地ID，由chooseImage接口获得
            isShowProgressTips: 1, // 默认为1，显示进度提示
            success: function (res) {
                images.serverId.push(res.serverId);
                var localId = localIds[i];
                if (ios) {
                    wx.getLocalImgData({
                        localId: localId,
                        success: function(res) {
                            var localData = res.localData; // localData是微信IOS端图片的base64数据,可以用img标签显示
                            localData = localData.replace('jgp', 'jpeg');
                            if (imgContainer.attr("data-count") == "1") { //单张图片的处理
                                $("#add-img").before('<a href="javascript:;" class="weui-grid js_grid multiImg">' +
                                    '<div class="close" style="position: absolute;top:0;right:0;height:32px;width:32px"><img src="/images/delPic.png" onclick="delPic(this);"></div><img style="width:108px;height:106px" src="' + localData + '"/></a>');
                                $("#add-img").css("display", 'none');
                            }
                            if (imgContainer.attr("data-count") == "3") { //多张图片的处理
                                if (count == 0) {
                                    $("#add-img").css("display", 'none');
                                }
                                $("#add-img").before(' <a href="javascript:;" class="weui-grid js_grid multiImg"><div class="close" style="position: absolute;top:0;right:0;height:32px;width:32px"><img src="/images/delPic.png" onclick="delImg(this);"></div><img style="width:108px;height:106px" name="pic" src="' + localData + '"/></a>');

                            }
                        },
                        fail: function() {
                            alert('该图片暂时无法查看');
                        }
                    });
                } else {
                    if (imgContainer.attr("data-count") == "1") {//单张图片的处理
                        $("#add-img").before('<a href="javascript:;" class="weui-grid js_grid multiImg">' +
                            '<div class="close" style="position: absolute;top:0;right:0;height:32px;width:32px"><img src="/images/delPic.png" onclick="delPic(this);"></div><img style="width:108px;height:106px" src="' + localId + '"/></a>');
                        $("#add-img").css("display", 'none');
                    } if (imgContainer.attr("data-count") == "3") { //多张图片的处理
                        if (count == 0) {
                            $("#add-img").css("display", 'none');
                        }
                        $("#add-img").before(' <a href="javascript:;" class="weui-grid js_grid multiImg"><div class="close" style="position: absolute;top:0;right:0;height:32px;width:32px"><img src="/images/delPic.png" onclick="delImg(this);"></div><img style="width:108px;height:106px" name="pic" src="' + localId + '"/></a>');
                    }
                }
                var mediaId = res.serverId; // 返回图片的服务器端ID，即mediaId
                //将获取到的 mediaId 传入后台 方法savePicture
                $.post("api/WxPictures",
                    { mediaId: mediaId, picType: imgContainer.attr("data-type") },
                    function (res) {
                        if (res.isSuccess) {
                            var multi = imgContainer.find(".multiImg");
                            $(multi[multi.length - 1])
                                .prepend('<input type="hidden" name="img" class="img" value="' + res.data + '" />');
                        }
                        // alert(multi[multi.length-1].innerHTML);
                        i++;
                        if (i < picNum) { //递归方法循环上传图片
                            upload();
                        }
                    });
            },
            fail: function (res) {
                $.toast('上传失败，请重新上传！' + res);
            }
        });
    }
    upload();
}

function openCamera() {
    wx.chooseImage({
        count: 3, // 默认9
        sizeType: ['original', 'compressed'], // 指定是原图还是压缩图，默认都有
        sourceType: ['album', 'camera'], // 指定来源是相册还是相机，默认都有
        success: function (res) {
            var localIds = res.localIds; // 返回选定照片的本地ID列表，localId可以作为img标签的src属性显示图片
            count = count - res.localIds.length;
            images.localId = res.localIds;
            uploadImage(images.localId, $imgContainer);
            //wx.previewImage({
            //    current: localIds[0], // 当前显示图片的http链接
            //    urls: localIds // 需要预览的图片http链接列表
            //});
            //wx.uploadImage({
            //    localId: localIds.toString(), // 需要上传的图片的ID，由chooseImage接口获得
            //    isShowProgressTips: 1, // 进度提示
            //    success: function (res) {
            //        var mediaId = res.serverId; // 返回图片的服务器端ID，即mediaId
            //        //将获取到的 mediaId 传入后台 方法savePicture

            //        $.post(path + "/getImage/savePicture", { "mediaId": mediaId, "tmp": "填写证件的正反面参数" }, function (res) {
            //            //填写你自己的业务逻辑
            //        });
            //    },
            //    fail: function (res) {
            //        $.toast('图片上传失败，请重试');
            //    }
            //});
        }
    });}