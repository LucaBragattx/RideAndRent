<%@ Page Title="" Language="C#" MasterPageFile="~/View/Driver/DriverMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RideYouRentST10090990.View.Driver.Cars" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8"></div>
            <div class="col-md-4 ml-5"></div>
            <div class="col-md-4">
                <label id="DriverName" runat="server">xxxxx</label>
                </div>

        </div>
         <div class="row">
             <div class="col-md-3"></div>
             <div class="col">
                 <form runat="server">
                      <div class="col-md-8">
                <h3>Avaliable Cars</h3>
                <asp:GridView runat="server" ID="CarList" Class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                </asp:GridView>
            </div>
                     <div class="row">
                         <div class="col-4">
                             <div class="form-group">
      <input type="date" class="form-control" id="ReturnDate" placeholder="Enter User Mobile" runat="server" required="required">
   </div>
                         </div>
                         <div class="col-4">
                         <div class="form-group d-grid">
                          <label id="InfoMsg" runat="server" class="text-black">...</label>
              <asp:Button type="submit" ID="Bookbtn" class="btn btn-danger btn-block" Text="Book" runat="server" OnClick="Bookbtn_Click"/>
                             </div>
              </div>
                     </div>
                 </form>
             </div>
                          </div>
        
         </div>
</asp:Content>
