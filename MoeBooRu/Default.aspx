<%@ Page Title="ホーム ページ" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MoeBooRu._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <ul id="tiles">
        <asp:Repeater ID="Previews" runat="server">
            <ItemTemplate>
                <li>
                    <img src="<%# ((MoeBooRu.Post)Container.DataItem).preview_url %>" 
                        width="<%# ((MoeBooRu.Post)Container.DataItem).actual_preview_width %>" 
                        height="<%# ((MoeBooRu.Post)Container.DataItem).actual_preview_height %>" 
                        alt="<%# ((MoeBooRu.Post)Container.DataItem).tags %>">
                    <p><%# ((MoeBooRu.Post)Container.DataItem).author%></p>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
<asp:Content ID="FooterContent" runat="server" ContentPlaceHolderID="FootContent">
<!-- Once the page is loaded, initalize the plug-in. -->
    <script type="text/javascript">
        $(document).ready(new function () {
            // Prepare layout options.
            var options = {
                autoResize: true, // This will auto-update the layout when the browser window is resized.
                container: $('#main'), // Optional, used for some extra CSS styling
                offset: 2, // Optional, the distance between grid items
                itemWidth: 310 // Optional, the width of a grid item
            };

            // Get a reference to your grid items.
            var handler = $('#tiles li');

            // Call the layout function.
            handler.wookmark(options);

            // Capture clicks on grid items.
            handler.click(function () {
                // Randomize the height of the clicked item.
                var newHeight = $('img', this).height() + Math.round(Math.random() * 300 + 30);
                $(this).css('height', newHeight + 'px');

                // Update the layout.
                handler.wookmark();
            });
        });
  </script>
</asp:Content>