/** layuiAdmin.std-v1.2.0 LPPL License By http://www.layui.com/admin/ */
 ;layui.define(["table","form"],function(e){var i=layui.$,o=layui.table;layui.form;o.render({elem:"#LAY-app-forum-list",url:layui.setter.base+"json/forum/list.js",cols:[[{type:"checkbox",fixed:"left"},{field:"id",width:100,title:"ID",sort:!0},{field:"poster",title:"发帖人"},{field:"avatar",title:"头像",width:100,templet:"#imgTpl"},{field:"content",title:"发帖内容"},{field:"posttime",title:"发帖时间",sort:!0},{field:"top",title:"置顶",templet:"#buttonTpl",minWidth:80,align:"center"},{title:"操作",width:150,align:"center",fixed:"right",toolbar:"#table-forum-list"}]],page:!0,limit:10,limits:[10,15,20,25,30],text:"对不起，加载出现异常！"}),o.on("tool(LAY-app-forum-list)",function(t){t.data;if("del"===t.event)layer.confirm("确定删除此条帖子？",function(e){t.del(),layer.close(e)});else if("edit"===t.event){i(t.tr);layer.open({type:2,title:"编辑帖子",content:"../../../views/app/forum/listform.html",area:["550px","400px"],btn:["确定","取消"],resize:!1,yes:function(t,e){var i=window["layui-layer-iframe"+t],l="LAY-app-forum-submit",r=e.find("iframe").contents().find("#"+l);i.layui.form.on("submit("+l+")",function(e){e.field;o.reload("LAY-app-forum-list"),layer.close(t)}),r.trigger("click")},success:function(e,t){}})}}),o.render({elem:"#LAY-app-forumreply-list",url:layui.setter.base+"json/forum/replys.js",cols:[[{type:"checkbox",fixed:"left"},{field:"id",width:100,title:"ID",sort:!0},{field:"replyer",title:"回帖人"},{field:"cardid",title:"回帖ID",sort:!0},{field:"avatar",title:"头像",width:100,templet:"#imgTpl"},{field:"content",title:"回帖内容",width:200},{field:"replytime",title:"回帖时间",sort:!0},{title:"操作",width:150,align:"center",fixed:"right",toolbar:"#table-forum-replys"}]],page:!0,limit:10,limits:[10,15,20,25,30],text:"对不起，加载出现异常！"}),o.on("tool(LAY-app-forumreply-list)",function(l){l.data;if("del"===l.event)layer.confirm("确定删除此条评论？",function(e){l.del(),layer.close(e)});else if("edit"===l.event){i(l.tr);layer.open({type:2,title:"编辑评论",content:"../../../views/app/forum/replysform.html",area:["550px","350px"],btn:["确定","取消"],resize:!1,yes:function(e,t){var i=t.find("iframe").contents().find("#layuiadmin-form-replys").find('textarea[name="content"]').val();l.update({content:i}),layer.close(e)},success:function(e,t){}})}}),e("forum",{})});