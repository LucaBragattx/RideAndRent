<%@ Page Title="" Language="C#" MasterPageFile="~/View/Inspector/InspectorMaster.Master" AutoEventWireup="true" CodeBehind="Rentals.aspx.cs" Inherits="RideYouRentST10090990.View.Inspector.Rentals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-1"></div>
                    <div class="col-9">
                    <h3 class="text-success">Rented Cars</h3>
                    <div class="col"><img src="../../Assets/Img/login.jpg" height="130px"></div>
                    <div class="col"></div>
                </div>
                <div class="row"> </div>
                    <div class="col-lg-1"></div>
                    <div class="col-lg-9">
               
        <form runat="server">
            <asp:GridView runat="server" ID="RentList" Class="table" AutoGenerateSelectButton="True" >
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                </asp:GridView> 
            <div class="form-group">
                    <label class="form-check-label" for="exampleCheck1">Elapse Date</label>
                    <input class="form-control" type="text" id="Finetb" runat="server">
                     <label class="form-check-label" for="exampleCheck1">Fine</label>
                     <input class="form-control" type="text" id="Elapsetb" runat="server">
                    </div>
            
                            <br />
                                <label id="InfoMsg" runat="server"></label><br />
                            <div class="form-group d-grid">
                                &nbsp;<asp:Button type="submit" ID="CreateBtn" class="btn btn-danger btn-block" Text="Create" runat="server" OnClick="CreateBtn_Click1"/>
              </div>
            <br />
               <div class="form-group d-grid">
              <asp:Button type="submit" ID="RetrieveBtn" class="btn btn-danger btn-block" Text="Retrieve" runat="server" OnClick="RetrieveBtn_Click"/>
              </div>
                            
                        </form>

                    </div>
                </div>
            </div>
        </div>
</asp:Content>
