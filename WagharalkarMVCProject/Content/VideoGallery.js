var saveVideoGallery = function () {
    var title = $("#txtTitle").val();
    var youtubeUrl = $("#txtYouTubeUrl").val();
    var type = $("#txtType").val();
    var createdate = $("#txtCreateDate").val(); 
    var updatedate = $("#txtUpdateDate").val();
    var createdby = $("#txtCreatedby").val(); 
    var updatedby = $("#txtUpdatedby").val();


    var model = {
        Title: title, YouTubeUrl: youtubeUrl, Type: type, CreateDate: createdate, UpdateDate: updatedate,
        CreatedBy: createdby, UpdatedBy: updatedby
    };

    $.ajax({
        url: "/VideoGallery/saveVideoGallery",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(model),
        datatype: "json",
        success: function (response) {
            alert(response.Message);
        }
    });
}