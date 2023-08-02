<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebClient._Default" %>
 
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
  <script type="text/javascript" >
  //This will allow the jQuery to access the cross domain
      jQuery.support.cors = true; 

      function RefreshPage() {
          var serviceUrl = "http://saravana:8090/MyService/EmployeeService/Employee";

          $.ajax({
              type: "GET",
              url: serviceUrl,
              dataType: 'json',
              contentType: "application/json; charset=utf-8",
              success: function (data) {
                  var itemRow = "<table>";
                  $.each(data, function (index, item) {
                      itemRow += "<tr><td>" + item.EmpId + "</td><td>" + item.Fname + "</td></tr>";
                  });
                  itemRow += "</table>";

                  $("#divItems").html(itemRow);

              },
              error: ServiceFailed
          });
      }

      function POSTMethodCall() {
           var EmpUser = [{ "EmpId": "13", "Fname": "WebClientUser", "Lname": "Raju", "JoinDate": Date(1224043200000), "Age": "23", "Salary": "12000", "Designation": "Software Engineer"}];
           var st = JSON.stringify(EmpUser);
           debugger;
          $.ajax({
              type: "POST",
              url: "http://saravana:8090/MyService/EmployeeService/EmployeePOST",
              data: JSON.stringify(EmpUser),
               contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (data) {
                  // Play with response returned in JSON format
              },
              error:ServiceFailed
          });

      }
      function DELETEMethodCall() {
          $.ajax({
              type: "DELETE",
              url: "http://saravana:8090/MyService/EmployeeService/Employee/2",
              data: "{}",
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (data) {
                  // Play with response returned in JSON format
              },
              error: function (msg) {
                  alert(msg);
              }
          });

      }

      function PUTMethodCall() {
          var EmpUser = [{ "EmpId": "3", "Fname": "WebClientUser", "Lname": "Raju", "JoinDate": Date(1224043200000), "Age": "23", "Salary": "12000", "Designation": "Software Engineer"}];

          $.ajax({
              type: "PUT",
              url: "http://saravana:8090/MyService/EmployeeService/EmployeePUT",
              data: EmpUser,
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (data) {
                  // Play with response returned in JSON format
              },
              error: ServiceFailed
          });

      }
      function ServiceFailed(xhr) {
           alert(xhr.responseText);

          if (xhr.responseText) {
              var err = xhr.responseText;
              if (err)
                  error(err);
              else
                  error({ Message: "Unknown server error." })
          }

          return;
      }
      function RefreshPage2() { alert("hi"); }
  </script>
<input type="button" onclick="PUTMethodCall();" name="btnUpdate"  value ="Update" />
<input type="button" onclick="DELETEMethodCall();" name="btnDelete"  value ="Delete" />
<input type="button" onclick="POSTMethodCall();" name="btnAdd"  value ="Add" />
<input type="button" onclick="RefreshPage()" name="btnRefesh"  value ="Refresh" />
    <div id="divItems"></div>
   
</asp:Content>
