$(document).ready(function () {
    getList();
})
var saveActivity = function () {
    var title = $("#txtTitle").val();
    var details = $("#txtDetails").val();
    var image1 = $("#txtImage1").val();
    var image2 = $("#txtImage2").val();
    var type = $("#txtType").val();
    var date = $("#txtDate").val();
    var createdate = $("#txtCreateDate").val();
    var updatedate = $("#txtUpdateDate").val();
    var createdby = $("#txtCreatedby").val();
    var updatedby = $("#txtUpdatedby").val();


    var model = {
        Title: title,
        Details: details,
        Image1: image1,
        Image2: image2,
        Type: type,
        Date: date,
        CreateDate: createdate,
        UpdateDate: updatedate,
        CreatedBy: createdby,
        UpdatedBy: updatedby
    };

    $.ajax({
        url: "/Activity/saveActivity",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(model),
        datatype: "json",
        success: function (response) {
            alert(response.Message);
        }
    });


}
//3.
var getList = function () {
    $.ajax({
        url: "/Activity/GetActivityList",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        //data: JSON.stringify(model),//model ne data waps yeil, no need to stringify data is in json format
        datatype: "json",
        async: false,
        success: function (response) {


            var html = "";

            $("#tblactivity tbody").empty();

            $.each(response.model, function (index, elementValue) {
                //elementValue--> this is used to fetch and display model value to table
                html += "<tr><td>" + elementValue.ID + "</td><td>" + elementValue.Title + "</td><td>" + elementValue.Details
                    + "</td><td>" + elementValue.Image1 + "</td><td>" + elementValue.Image2 + "</td><td>" + elementValue.Type + "</td><td>" + elementValue.Date
                    + "</td><td>" + elementValue.CreateDate + "</td><td>" + elementValue.UpdateDate + "</td><td>" + elementValue.CreatedBy + "</td><td>" + elementValue.UpdatedBy + "</td></tr>";


            }
            );
            $("#tblactivity tbody").append(html);
        }
    });


}