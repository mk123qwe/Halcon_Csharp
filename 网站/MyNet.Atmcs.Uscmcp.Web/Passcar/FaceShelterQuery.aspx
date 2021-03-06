﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FaceShelterQuery.aspx.cs" Inherits="MyNet.Atmcs.Uscmcp.Web.FaceShelterQuery" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>遮挡面部</title>
    <!--卡口选择插件引用开始-->
    <%-- <script type="text/javascript" src="../KakouSelect/js/jquery-1.4.4.min.js"></script>--%>
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.js"></script>
    <link href="../KakouSelect/css/demo.css" rel="stylesheet" />
    <link href="../KakouSelect/css/zTreeStyle/zTreeStyle.css" rel="stylesheet" />
    <script type="text/javascript" src="../KakouSelect/js/jquery.ztree.core.js"></script>
    <script type="text/javascript" src="../KakouSelect/js/jquery.ztree.excheck.js"></script>

    <!--卡口选择插件引用结束-->
    <!--图片放大开始-->

    <script type="text/javascript" src="../Scripts/Zoom/jquery.photo.gallery.js"></script>
    <!--图片放大结束-->
    <meta http-equiv="Content-Type" content="text/html" charset="GBK" />
    <link rel="stylesheet" href="../Css/showphotostyle.css" type="text/css" />
    <script type="text/javascript" src="../Scripts/laydate/laydate.js" charset="UTF-8"></script>
    <%--  <script type="text/javascript" src="../Scripts/jquery.min_v1.0.js" charset="UTF-8"></script>--%>
    <script src="../Scripts/showphoto.js" type="text/javascript" charset="UTF-8"></script>
    <link rel="stylesheet" href="../Css/cabel-v1.css" type="text/css" />
    <link rel="Stylesheet" href="../Styles/datetime.css" type="text/css" />
    <style type="text/css">
        .images-view .x-panel-body {
            background: white;
            font: 11px Arial, Helvetica, sans-serif;
        }

        .images-view .thumb {
            background: #dddddd;
            padding: 3px;
        }

            .images-view .thumb img {
                height: 60px;
                width: 80px;
            }

        .images-view .thumb-wrap {
            float: left;
            margin: 4px;
            margin-right: 0;
            padding: 5px;
            text-align: center;
        }

            .images-view .thumb-wrap span {
                display: block;
                overflow: hidden;
                text-align: center;
            }

        .images-view .x-view-over {
            border: 1px solid #dddddd;
            background: #efefef url(../images/row-over.gif) repeat-x left top;
            padding: 4px;
        }

        .images-view .x-view-selected {
            background: #eff5fb url(../images/selected.gif) no-repeat right bottom;
            border: 1px solid #99bbe8;
            padding: 4px;
        }

            .images-view .x-view-selected .thumb {
                background: transparent;
            }

        .images-view .loading-indicator {
            font-size: 11px;
            background-image: url(../images/loading.gif);
            background-repeat: no-repeat;
            background-position: left;
            padding-left: 20px;
            margin: 10px;
        }

        .fis {
            display: inline-block;
            float: left;
            width: 33.333%;
            height: 220px;
        }

        #FormPanel1-xcollapsed {
            display: none !important;
        }
    </style>
    <script type="text/javascript">
        function ShowImage(image1, image2, image3, palteid, platetype) {
            document.getElementById("zjwj1").src = image1;
            document.getElementById("zjwj2").src = image2;
            document.getElementById("zjwj3").src = image3;
            ChangeBackColor("divplateId", platetype, palteid);
        }
        var DataAmply = function () {
            return '<img class="imgEdit" ext:qtip="查看详细信息" style="cursor:pointer;" src="../images/button/vcard_edit.png" />';
        };
        function ChangeBackColor(id, hpzl, hphm) {

            var obj = document.getElementById(id);
            obj.innerText = hphm;
            switch (hpzl) {

                case "01":
                    obj.style.color = "#000000";
                    obj.style.background = "FFFF00";
                    break;
                case "02":
                    obj.style.color = "#FFFFFF";
                    obj.style.background = "000080";
                    break;
                case "06":
                    obj.style.color = "#FFFFFF";
                    obj.style.background = "000000";
                    break;
                case "23":
                    obj.style.color = "FF0000";
                    obj.style.background = "FFFFFF";
                    break;
                default:
                    obj.style.color = "#FFFFFF";
                    obj.style.background = "000080";
                    break;

            }
        }
        var cellClick = function (grid, rowIndex, columnIndex, e) {
            var t = e.getTarget(),
            //record = grid.getStore().getAt(rowIndex),  // Get the Record
                columnId = grid.getColumnModel().getColumnId(columnIndex); // Get column id

            if (columnId == "Details") {
                return true;
            }
            return false;
        };
        $(function () {
            //报警信息查询，点击单行数据，下面显示图片介绍
            $("body").delegate(".x-grid3-row", "click", function () {

                var aDiv = $("#FormPanel1 .photoblock-many").html();

                //如果当前元素有class,导入div
                if (!$(this).hasClass("import")) {
                    //每次点击，删除之前已经存在的div;
                    $(".import").removeClass("import").next().remove();
                    $(this).addClass("import");
                    $(aDiv).insertAfter($(this));
                }
                else {
                    //   $(this).removeClass("import").next().remove();
                }

            })
        })
        function directclear() {
            try {

                clearSelect(TreeStation, FieldStation);
                // clearSelect(document.getElementById("TreeStation"), document.getElementById("FieldStation"));
            } catch (e) {

            }

        }

        //清理选中
        var clearSelect = function (tree, field) {
            var ids = field.getValue();
            if (ids.length > 0) {
                try {
                    //设置 取消勾选
                    tree.setChecked({ ids: ids, silent: false });
                } catch (e) {
                }
            }
            //tree.getRootNode().collapseChildNodes(true);
        };
        // 获得选中value
        var getValues = function (tree) {
            var msg = [],
                selNodes = tree.getChecked();
            Ext.each(selNodes, function (node) {
                msg.push(node.id);
            });
            return msg.join(",");
        };
        // 获得选中text
        var getText = function (tree) {
            var msg = [],
                selNodes = tree.getChecked();
            Ext.each(selNodes, function (node) {
                msg.push(node.text);
            });
            return msg.join(",");
        };

        var syncValue = function (value) {
            var tree = this.component;
            if (tree.rendered) {
                if (value) {
                    var ids = value.split(",");
                    try {
                        tree.setChecked({ ids: ids, silent: true });
                        tree.getSelectionModel().clearSelections();
                        Ext.each(ids, function (id) {
                            var node = tree.getNodeById(id);
                            if (node) {
                                node.ensureVisible(function () {
                                    tree.getSelectionModel().select(tree.getNodeById(this.id), null, true);
                                }, node);
                            }
                        }, this);
                    } catch (e) { }
                }
            }
        };
        var AllowInputNumberGsd = function () {
            txtGsd.setValue(txtGsd.getValue().replace(/[^\d\d]/g, "")); //只能输入数字
        }
        var AllowInputNumberDsd = function () {
            txtDsd.setValue(txtDsd.getValue().replace(/[^\d\d]/g, "")); //只能输入数字
        }
    </script>
    <script type="text/javascript">
        var IMGDIR = '../images/sets';
        var attackevasive = '0';
        var gid = 0;
        var fid = parseInt('0');
        var tid = parseInt('0');
    </script>
    <!--卡口选择插件Js开始-->

    <script type="text/javascript">
        //选中
        var setSelect = function (kakouNames) {
            Window1.hide();
            $.post("Getjson.ashx", "", function (data) {
                zNodes = eval(data);
                if (zNodes != null) {
                    $.fn.zTree.init($("#treeDemo"), setting, zNodes);
                }
            });
            $("#kakou").val(kakouNames);
        };
        var setting = {
            check: {
                enable: true,
                chkboxType: { "Y": "ps", "N": "ps" }
            },
            view: {
                dblClickExpand: false
            },
            data: {
                simpleData: {
                    enable: true
                }
            },
            callback: {
                beforeClick: beforeClick,
                onCheck: onCheck
            }
        };

        function beforeClick(treeId, treeNode) {
            var zTree = $.fn.zTree.getZTreeObj("treeDemo");
            zTree.checkNode(treeNode, !treeNode.checked, null, true);
            return false;
        }
        var xianshi = null;
        //选择卡口复选框时触发
        function onCheck(e, treeId, treeNode) {
            try {
                var zTree = $.fn.zTree.getZTreeObj("treeDemo");

                nodes = zTree.getCheckedNodes(true);

                var v = "";
                var ids = "";
                for (var i = 0, l = nodes.length; i < l; i++) {
                    if (nodes[i].isParent == true) {//把部门去除
                        continue;
                    }
                    v += nodes[i].name + ",";
                    ids += nodes[i].id + ",";
                }
                if (v.length > 0) v = v.substring(0, v.length - 1);
                if (ids.length > 0) ids = ids.substring(0, ids.length - 1);
                var cityObj = $("#kakou");
                cityObj.attr("value", v);
                //alert(ids);
                $("#kakouId").val(ids);

            } catch (e) {

            }

        }

        //显示卡口下拉
        function showMenu(event) {
            $("#selectKakou").css("display", "none");
            var cityObj = $("#kakou");
            var cityOffset = $("#kakou").offset();
            if ($("#menuContent").css("display") == "block") {
                $("#menuContent").css("display", "none");
            }
            else {
                $("#menuContent").css({ left: (cityOffset.left) + "px", top: (cityOffset.top) + cityObj.outerHeight() + "px" }).slideDown("fast");

            }
            event.stopPropagation();
        }
        //隐藏卡口下拉
        function hideMenu() {
            $("#menuContent").css("display", "none");
        }
        function hideMenuSelect() {
            $("#selectKakou").css("display", "none");
        }
        //清除
        function clearMenu() {
            $("#kakou").val("");

            var zTree = $.fn.zTree.getZTreeObj("treeDemo");
            zTree.checkAllNodes(false);
            FaceShelterQuery.ClearKakou();
        }
        var zNodes = null;

        $(document).ready(function () {
            $.post("Getjson.ashx", "", function (data) {
                zNodes = eval(data);
                if (zNodes != null) {
                    $.fn.zTree.init($("#treeDemo"), setting, zNodes);
                }
            });

        });
        document.onclick = function () {

            //$("#menuContent").hide();

        }
        function showSelect(event) {
            var code = event.keyCode;
            if (code == 13 || code == 32) {
                FaceShelterQuery.GetKakou();
            }
        }
        function setUl(lis) {
            $("#menuContent").css("display", "none");
            var cityObj = $("#kakou");
            var cityOffset = $("#kakou").offset();

            $("#selectKakou").css({ left: (cityOffset.left) + "px", top: (cityOffset.top) + cityObj.outerHeight() + "px" }).slideDown("fast");
            var json = eval(lis);
            var strs = "";
            if (json[0].name == "none") {
                strs += "<li style='margin-top:150px;margin-left:120px;'> 当前没查询到无数据 </li>";
            } else {
                for (var i = 0; i < json.length; i++) {
                    strs += "<li onclick='setInput(this)' style='margin-left:10px;margin-top:5px;color:white;height:28px;line-height:28px;text-align:left;text-indent:8px;font-size:14px;overflow:hidden;' class='" + json[i].id + "'>" + json[i].name + " </li>";
                }
            }
            $("#showKakou").html(strs);

        }
        //卡口模糊查询的时候，点击下面卡口给文本框赋值
        function setInput(li) {
            $("#kakou").val(""); $("#kakouId").val("");
            $("#kakou").val(li.innerText);
            $("#kakouId").val(li.className);
            FaceShelterQuery.SetSession();
            $.post("Getjson.ashx", "", function (data) {
                zNodes = eval(data);
                if (zNodes != null) {
                    $.fn.zTree.init($("#treeDemo"), setting, zNodes);
                }
            });
        }
        function returnKakou() {
            $("#menuContent").css("display", "block");
            $("#selectKakou").css("display", "none");
        }
        //鼠标悬浮在行上有提示信息（展示的时候）
        var showTip = function () {
            var rowIndex = GPResult.view.findRowIndex(this.triggerElement),
                cellIndex = GPResult.view.findCellIndex(this.triggerElement),
                record = Store2.getAt(rowIndex),
                fieldName = GPResult.getColumnModel().getDataIndex(cellIndex),
                data = record.get(fieldName);
            if (fieldName == "gwsj") {

                data = data.toString().substring(0, 10) + " " + data.toString().substring(11, 19);
            }
            this.body.dom.innerHTML = data;
        };
    </script>

    <!--卡口选择插件结束-->
</head>
<body>
    <form id="form1" runat="server">
        <div id="append_parent">
        </div>
        <ext:Hidden ID="FormatType" runat="server" />
        <ext:Hidden ID="realCount" runat="server" />
        <ext:Hidden ID="curpage" runat="server" />
        <ext:Hidden ID="allPage" runat="server" />
        <ext:ResourceManager ID="ResourceManager1" runat="server" DirectMethodNamespace="FaceShelterQuery" />
        <ext:Viewport ID="Panel1" runat="server" Layout="border">
            <Items>
                <ext:FormPanel ID="Panel2" runat="server" Region="North" Title="">
                    <TopBar>
                        <ext:Toolbar runat="server" Layout="ContainerLayout">
                            <Items>
                                <ext:Toolbar runat="server" LabelAlign="Right">
                                    <Items>
                                        <ext:Panel runat="server" Height="40">
                                            <Content>
                                                <table style="width: 400px">
                                                    <tr>
                                                        <td style="width: 50px">
                                                            <span class="laydate-span" style="height: 30px; font-size: 15px; margin-left: 12px; margin-right: 2px; margin-top: 5px;">查询时间：</span></td>
                                                        <td style="width: 150px">
                                                            <li class="laydate-icon" id="start" runat="server" style="width: 150px; height: 25px; line-height: 22px!important; margin-left: 5px;"></li>
                                                        </td>
                                                        <td style="width: 20px;"><span class="laydate-span" style="height: 30px; margin-left: 16px; margin-right: 16px">--</span>
                                                        </td>
                                                        <td style="width: 150px">
                                                            <li class="laydate-icon" id="end" runat="server" style="width: 150px; height: 25px;"></li>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </Content>
                                        </ext:Panel>
                                        <%--  <ext:Label ID="Label2" runat="server" Text="卡口列表：" StyleSpec="margin-left:10px;">
                                        </ext:Label>
                                        <ext:DropDownField ID="FieldStation" runat="server"
                                            Editable="false" Width="400px" TriggerIcon="SimpleArrowDown" Mode="ValueText">
                                            <Component>
                                                <ext:TreePanel runat="server" Height="400" Shadow="None" ID="TreeStation"
                                                    UseArrows="true" AutoScroll="true" Animate="true" EnableDD="true" ContainerScroll="true" RootVisible="true"
                                                    StyleSpec="background-color: rgba(68,138,202,0.9); border-radius: 20px;">
                                                    <Root>
                                                    </Root>
                                                    <Buttons>
                                                        <ext:Button runat="server" Text="清除">
                                                            <Listeners>
                                                                <Click Handler="clearSelect(TreeStation,FieldStation);" />
                                                            </Listeners>
                                                        </ext:Button>
                                                        <ext:Button runat="server" Text="关闭">
                                                            <Listeners>
                                                                <Click Handler="#{FieldStation}.collapse();" />
                                                            </Listeners>
                                                        </ext:Button>
                                                    </Buttons>
                                                    <Listeners>
                                                        <CheckChange Handler="this.dropDownField.setValue(getValues(this), getText(this), false);" />
                                                    </Listeners>
                                                    <SelectionModel>
                                                        <ext:MultiSelectionModel runat="server" />
                                                    </SelectionModel>
                                                </ext:TreePanel>
                                            </Component>
                                            <Listeners>
                                                <Expand Handler="this.component.getRootNode().expand(false);" Single="true" Delay="20" />
                                            </Listeners>
                                            <SyncValue Fn="syncValue" />
                                        </ext:DropDownField>--%>
                                        <ext:Panel runat="server">
                                            <Content>
                                                <span style="margin-top: 5px; font-size: 15px; margin-left: 13px; margin-right: 10px; float: left;">卡口列表：</span>
                                                <input id="kakou" onkeyup="showSelect(event)" runat="server" type="text" value="" onclick="showMenu(event);" />
                                                <input onclick="showMenu(event);" id="kakouXiala" type="button"></input>
                                                <%--  <input runat="server" type="button" id="htmlBtn" />--%>
                                                <input id="kakouId" runat="server" hidden="hidden" />
                                            </Content>
                                        </ext:Panel>
                                        <ext:Checkbox ID="CBZjs" runat="server" BoxLabel="驾驶人" Style="margin-left: 10px" />
                                        <ext:Checkbox ID="CBFjs" runat="server" BoxLabel="副驾驶" Style="margin-left: 10px" />
                                        <%-- <ext:ToolbarFill runat="server"></ext:ToolbarFill>--%>
                                        <ext:Button ID="Button5" Width="75" runat="server" Icon="ControlPlayBlue" Text="查询" OnDirectClick="Button5_DirectClick"></ext:Button>
                                    </Items>
                                </ext:Toolbar>
                            </Items>
                        </ext:Toolbar>
                    </TopBar>
                    <%-- <Items>
                    </Items>--%>
                </ext:FormPanel>
                <ext:GridPanel ID="GPResult" Region="Center" runat="server" StripeRows="true" Height="400" TrackMouseOver="true">
                    <TopBar>

                        <ext:Toolbar runat="server" Layout="ContainerLayout">
                            <Items>

                                <ext:Toolbar runat="server" Layout="Container">
                                    <Items>
                                        <ext:Toolbar runat="server">
                                            <Items>
                                                <ext:ToolbarSpacer ID="ToolbarSpacer3" runat="server" Width="10" />
                                                <%-- <ext:Button ID="ButFisrt" runat="server" Text="首页" Disabled="true">
                                                    <DirectEvents>
                                                        <Click OnEvent="TbutFisrt" />
                                                    </DirectEvents>
                                                </ext:Button>--%>
                                                <ext:Button ID="ButLast" runat="server" Icon="ControlRewindBlue" Text="上一页" Disabled="true">
                                                    <DirectEvents>
                                                        <Click OnEvent="TbutLast" />
                                                    </DirectEvents>
                                                </ext:Button>
                                                <ext:Button ID="ButNext" runat="server" StyleSpec="margin-left:10px;" Icon="ControlFastforwardBlue" Text="下一页"
                                                    Disabled="true">
                                                    <DirectEvents>
                                                        <Click OnEvent="TbutNext" />
                                                    </DirectEvents>
                                                </ext:Button>

                                                <ext:Label ID="lblTitle" runat="server" Text="查询结果：当前是第" StyleSpec="margin-left:10px;" />
                                                <ext:Label ID="lblCurpage" runat="server" Text="" Cls="pageNumLabel" />
                                                <ext:Label ID="Label1" runat="server" Text="页,共有" />
                                                <ext:Label ID="lblAllpage" runat="server" Text="" Cls="pageNumLabel" />
                                                <ext:Label ID="Label9" runat="server" Text="页,共有" StyleSpec="font-weight:bolder;" />
                                                <ext:Label ID="lblRealcount" runat="server" Text="" Cls="pageNumLabel" />
                                                <ext:Label ID="Label12" runat="server" Text="条记录" />

                                                <ext:ToolbarFill runat="server"></ext:ToolbarFill>
                                                <ext:Button ID="ButExcel" runat="server" Text="导出Excel" AutoPostBack="true" OnClick="ToExcel"
                                                    Icon="PageExcel">
                                                </ext:Button>
                                            </Items>
                                        </ext:Toolbar>
                                    </Items>
                                </ext:Toolbar>
                            </Items>
                        </ext:Toolbar>
                    </TopBar>
                    <Store>
                        <ext:Store
                            ID="Store2"
                            runat="server"
                            OnRefreshData="Store2_RefreshData">
                            <Reader>
                                <ext:JsonReader>
                                    <Fields>
                                        <ext:RecordField Name="kkmc" Type="String" />
                                        <ext:RecordField Name="hphm" Type="String" />
                                        <ext:RecordField Name="hpzlms" Type="String" />
                                        <ext:RecordField Name="gwsj" Type="String" />
                                        <ext:RecordField Name="fxmc" Type="String" />
                                        <ext:RecordField Name="cdbh" Type="String" />
                                        <ext:RecordField Name="clsd" Type="String" />
                                        <%--<ext:RecordField Name="sjly" Type="String" />--%>
                                        <ext:RecordField Name="jllxms" Type="String" />
                                        <ext:RecordField Name="zjwj1" Type="String" />
                                        <ext:RecordField Name="zjwj2" Type="String" />
                                        <ext:RecordField Name="zjwj3" Type="String" />
                                        <%--<ext:RecordField Name="zdlx" Type="String" />--%>
                                    </Fields>
                                </ext:JsonReader>
                            </Reader>
                        </ext:Store>
                    </Store>
                    <ColumnModel runat="server" ID="ColumnModel1">
                        <Columns>
                            <ext:RowNumbererColumn Width="40"></ext:RowNumbererColumn>
                            <ext:Column ColumnID="kk" Header="卡口名称" DataIndex="kkmc" Align="Left">
                            </ext:Column>
                            <ext:Column Header="号牌号码" DataIndex="hphm" Align="Center">
                            </ext:Column>
                            <ext:Column Header="号牌种类" DataIndex="hpzlms" Align="Center">
                            </ext:Column>
                            <ext:DateColumn Header="过往时间" DataIndex="gwsj" Format="yyyy-MM-dd HH:mm:ss" Align="Center">
                            </ext:DateColumn>
                            <ext:Column Header="行驶方向" DataIndex="fxmc" Align="Center">
                            </ext:Column>
                            <ext:Column Header="车道" DataIndex="cdbh" Align="Center">
                            </ext:Column>
                            <ext:Column Header="车辆速度" DataIndex="clsd" Align="Center">
                            </ext:Column>
                            <%--<ext:Column Header="数据来源" DataIndex="sjly" Align="Center">
                            </ext:Column>--%>
                            <ext:Column Header="记录类型" DataIndex="jllxms" Align="Center">
                            </ext:Column>
                            <ext:Column DataIndex="zjwj1" Align="Center" Hidden="true">
                            </ext:Column>
                            <ext:Column DataIndex="zjwj2" Align="Center" Hidden="true">
                            </ext:Column>
                            <ext:Column DataIndex="zjwj3" Align="Center" Hidden="true">
                            </ext:Column>
                            <%-- <ext:Column Header="遮挡类型" DataIndex="zdlx" Align="Center">
                            </ext:Column>--%>
                        </Columns>
                    </ColumnModel>
                    <%--<SelectionModel>
                        <ext:CheckboxSelectionModel runat="server" />
                    </SelectionModel>--%>
                    <LoadMask ShowMask="true" />
                    <SelectionModel>
                        <ext:RowSelectionModel ID="RowSelectionModel1" runat="server" SingleSelect="true">
                            <DirectEvents>
                                <RowSelect OnEvent="ApplyClick" Buffer="250">
                                    <ExtraParams>
                                        <ext:Parameter Name="data" Value="record.data" Mode="Raw" />
                                    </ExtraParams>
                                </RowSelect>
                            </DirectEvents>
                        </ext:RowSelectionModel>
                    </SelectionModel>
                    <View>
                        <ext:GridView ID="GridView1" runat="server" ForceFit="true">
                        </ext:GridView>
                    </View>
                    <ToolTips>
                        <ext:ToolTip
                            ID="RowTip"
                            runat="server"
                            Target="={GPResult.getView().mainBody}"
                            Delegate=".x-grid3-cell"
                            TrackMouse="true">
                            <Listeners>
                                <Show Fn="showTip" />
                            </Listeners>
                        </ext:ToolTip>
                    </ToolTips>
                </ext:GridPanel>
                <%--右部--%>
                <ext:FormPanel ID="FormPanel1" runat="server" Region="East" Split="true" Frame="true"
                    Title="详细信息" Width="0" Height="0" Icon="Images" DefaultAnchor="100%" Collapsible="true"
                    AutoScroll="true" Collapsed="true">
                    <Content>
                        <div class="photoblock-many">
                            <center>
                                <div id="divplateId" style="width: 100%; font-size: 30pt; font-family: 微软雅黑; color: white; background-color: blue;">
                                </div>
                                <div class="container" style="width: 100%; height: 220px">
                                    <div class="fis">
                                        <img id="zjwj1" style="cursor: pointer" onclick="$.openPhotoGallery(this);" class="photo"
                                            src="../images/NoImage.png" alt="车辆图片(图片点击滚轮缩放)" width="100%" height="220" />
                                    </div>

                                    <div class="fis">
                                        <img id="zjwj2" style="cursor: pointer" onclick="$.openPhotoGallery(this);" class="photo"
                                            src="../images/NoImage.png" alt="车辆图片(图片点击滚轮缩放)" width="100%" height="220" />
                                    </div>

                                    <div class="fis">
                                        <img id="zjwj3" style="cursor: pointer" onclick="$.openPhotoGallery(this);" class="photo"
                                            src="../images/NoImage.png" alt="车辆图片(图片点击滚轮缩放)" width="100%" height="220" />
                                    </div>
                                </div>
                            </center>
                        </div>
                    </Content>
                </ext:FormPanel>
            </Items>
        </ext:Viewport>
        <!-- 显示卡口下拉框开始-->
        <div>
            <div id="menuContent" class="menuContent" style="display: none; position: absolute; z-index: 999; width: 389px; height: 377px;">
                <!--overflow-y: auto; overflow-x: hidden; -->
                <div style="position: relative; margin-top: 0px; width: 100%; height: 90%; overflow-y: auto; overflow-x: hidden; " class="kkselectStyle">
                    <ul id="treeDemo" class="ztree" style="margin-top: 0px; width: 100%; height: 90%;">
                    </ul>
                </div>
                <div style="position: relative; bottom: 0; height: 5%; padding-bottom: 10px;  border-radius: 0px 0px 15px 15px;" class="kkselectStyle">
                    <input type="button" value="清除" class="func_btn" onclick="clearMenu()" style="margin-left: 100px;" />

                    <input type="button" value="关闭" class="func_btn" onclick="hideMenu()" />
                </div>
            </div>
            <div id="selectKakou" style="display: none; position: absolute; z-index: 999; width: 389px; height: 377px; overflow-y: auto; overflow-x: hidden;">
                <div style="position: relative; margin-top: 0px; width: 100%; height: 90%; overflow-y: auto; overflow-x: hidden; " class="kkselectStyle">
                    <ul id="showKakou" style="margin-top: 0px; width: 100%; height: 90%;">
                    </ul>
                </div>

                <div style="position: relative; bottom: 0; height: 5%; padding-bottom: 10px;  border-radius: 0px 0px 15px 15px;" class="kkselectStyle">
                    <input type="button" class="func_btn" value="返回目录" onclick="returnKakou()" style="margin-left: 100px;" />

                    <input type="button" class="func_btn" value="关闭" onclick="hideMenuSelect()" />
                </div>
            </div>
        </div>
        <!-- 显示卡口下拉框结束-->
    </form>
</body>
</html>

<script type="text/javascript">
    var exportData = function (format) {
        FormatType.setValue(format);
        var store = GPResult.getStore();
        store.directEventConfig.isUpload = true;

        var records = store.reader.readRecords(store.proxy.data).records,
            values = [];

        for (i = 0; i < records.length; i++) {
            var obj = {}, dataR;

            if (store.reader.meta.id) {
                obj[store.reader.meta.id] = records[i].id;
            }

            dataR = Ext.apply(obj, records[i].data);

            if (!Ext.isEmptyObj(dataR)) {
                values.push(dataR);
            }
        }

        store.submitData(values);

        store.directEventConfig.isUpload = false;
    };
</script>

<script type="text/javascript">
    laydate.skin('danlan');
    var start = {
        elem: '#start',
        format: 'YYYY-MM-DD hh:mm:ss',
        //min: laydate.now(), //设定最小日期为当前日期
        max: '2099-06-16 23:59:59', //最大日期
        istime: true,
        istoday: true,
        choose: function (datas) {
            end.min = datas; //开始日选好后，重置结束日的最小日期
            end.start = datas //将结束日的初始值设定为开始日
            $("#end").click();//开始时间选中后，自动弹出结束时间
            var tt = $("#start").html();
            FaceShelterQuery.GetDateTime(true, tt);
            //alert(tt);
        }
    };
    var end = {
        elem: '#end',
        format: 'YYYY-MM-DD hh:mm:ss',
        min: laydate.now(),
        max: '2099-06-16 23:59:59',
        istime: true,
        istoday: true,
        choose: function (datas) {
            start.max = datas; //结束日选好后，重置开始日的最大日期
            var tt = $("#end").html();
            FaceShelterQuery.GetDateTime(false, tt);
        }
    };
    laydate(start);
    laydate(end);
</script>