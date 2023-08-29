<%@ Page Title="" Language="C#" MasterPageFile="~/View/Inspector/InspectorMaster.Master" AutoEventWireup="true" CodeBehind="Inspectors.aspx.cs" Inherits="RideYouRentST10090990.View.Inspector.Inspectors" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myBody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <h4 class="text-success">Manage Inspectors</h4>
                    <div class="col"><img src="../../Assets/Img/login.jpg" height="130px"></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form runat="server">
                             <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Inspector Number</label>
                                <input type="text" class="form-control" id="InspectorNumber1" placeholder="Enter Inspector Number" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Inspector Name</label>
                                <input type="text" class="form-control" id="InspectorName1" placeholder="Enter Inspector Name" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Inspector Email</label>
                                <input type="text" class="form-control" id="InspectorEmail1" placeholder="Enter Inspector Email" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Inspector Mobile</label>
                                <input type="text" class="form-control" id="InspectorMobile1" placeholder="Enter Inspector Mobile" runat="server">
                           </div>
  
                            <br />
                            
                            <label id="ErrorMsg" runat="server" class="text-danger"></label> <br />
                            <asp:Button type="submit" ID="CreateBtn" class="btn btn-danger" Text="Create" runat="server" OnClick="CreateBtn_Click"/>
                            <asp:Button type="submit" ID="ReadBtn" class="btn btn-danger" Text="Read" runat="server"/>
                            <asp:Button type="submit" ID="UpdateBtn" class="btn btn-danger" Text="Update" runat="server" OnClick="UpdateBtn_Click"/>
                            <asp:Button type="submit" ID="DeleteBtn" class="btn btn-danger" Text="Delete" runat="server" OnClick="DeleteBtn_Click"/>
                        </form>

                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <h1>Inspectors List</h1>
                <asp:GridView runat="server" ID="InspectorList" Class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="InspectorList_SelectedIndexChanged1" >
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
