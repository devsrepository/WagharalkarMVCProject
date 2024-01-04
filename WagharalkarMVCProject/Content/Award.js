var saveAward = function () {
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
        url: "/Award/saveAward",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(model),
        datatype: "json",
        success: function (response) {
            alert(response.Message);
        }


    });
}