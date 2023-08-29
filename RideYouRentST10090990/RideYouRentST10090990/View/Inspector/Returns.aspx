<%@ Page Title="" Language="C#" MasterPageFile="~/View/Inspector/InspectorMaster.Master" AutoEventWireup="true" CodeBehind="Returns.aspx.cs" Inherits="RideYouRentST10090990.View.Inspector.Returns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">

    <div class="container=fluid">
        <div class="row">
            <div class="col-md-5"></div>
            <div class="col-md-3"><img src="../../Assets/Img/login.jpg" height="180px" />
                <h3 class="text-black">Car Returned</h3>
            </div>
            <div class="col-md-3"></div>
        </div>
        <div class="row">
            <div class="col-lg-12"></div>
             <form runat="server">
                    <asp:GridView runat="server" ID="ReturnList" Class="table" AutoGenerateSelectButton="True" >
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                    </asp:GridView>
                            
                     <br />
                            <label id="InfoMsg" runat="server"></label><br />
                            <div class="form-group d-grid">
                             &nbsp;<asp:Button type="submit" ID="CreateBtn" class="btn btn-danger btn-block" Text="Create" runat="server"/>
                             </div>
                            <br />
                            <div class="form-group d-grid">
              <asp:Button type="submit" ID="RetrieveBtn" class="btn btn-danger btn-block" Text="Retrieve" runat="server" OnClick="RetrieveBtn2_Click"/>
              </div>
                 </form>
        </div>
        
    </div>
</asp:Content>
