/** layuiAdmin.std-v1.2.0 LPPL License By http://www.layui.com/admin/ */
 ;layui.define(["admin","table","util"],function(e){var l=layui.$,a=(layui.admin,layui.table),d=(layui.element,{all:{text:"全部消息",id:"LAY-app-message-all"},notice:{text:"通知",id:"LAY-app-message-notice"},direct:{text:"私信",id:"LAY-app-message-direct"}}),t=function(e){return'<a href="detail.html?id='+e.id+'">'+e.title};a.render({elem:"#LAY-app-message-all",url:layui.setter.base+"json/message/all.js",page:!0,cols:[[{type:"checkbox",fixed:"left"},{field:"title",title:"标题内容",minWidth:300,templet:t},{field:"time",title:"时间",width:170,templet:"<div>{{ layui.util.timeAgo(d.time) }}</div>"}]],skin:"line"}),a.render({elem:"#LAY-app-message-notice",url:layui.setter.base+"json/message/notice.js",page:!0,cols:[[{type:"checkbox",fixed:"left"},{field:"title",title:"标题内容",minWidth:300,templet:t},{field:"time",title:"时间",width:170,templet:"<div>{{ layui.util.timeAgo(d.time) }}</div>"}]],skin:"line"}),a.render({elem:"#LAY-app-message-direct",url:layui.setter.base+"json/message/direct.js",page:!0,cols:[[{type:"checkbox",fixed:"left"},{field:"title",title:"标题内容",minWidth:300,templet:t},{field:"time",title:"时间",width:170,templet:"<div>{{ layui.util.timeAgo(d.time) }}</div>"}]],skin:"line"});var s={del:function(e,t){var i=d[t];if(0===a.checkStatus(i.id).data.length)return layer.msg("未选中行");layer.confirm("确定删除选中的数据吗？",function(){layer.msg("删除成功",{icon:1}),a.reload(i.id)})},ready:function(e,t){var i=d[t];if(0===a.checkStatus(i.id).data.length)return layer.msg("未选中行");layer.msg("标记已读成功",{icon:1}),a.reload(i.id)},readyAll:function(e,t){var i=d[t];layer.msg(i.text+"：全部已读",{icon:1})}};l(".LAY-app-message-btns .layui-btn").on("click",function(){var e=l(this),t=e.data("events"),i=e.data("type");s[t]&&s[t].call(this,e,i)}),e("message",{})});