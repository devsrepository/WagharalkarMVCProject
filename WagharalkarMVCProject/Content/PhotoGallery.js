var savePhotoGallery = function () {
    //2.here forms field data taken to the variable.
    var title = $("#txtTitle").val();
    var image1 = $("#txtImage1").val();
    var image2 = $("#txtImage2").val();
    var type = $("#txtType").val();
    var createdate = $("#txtCreateDate").val();
    var updatedate = $("#txtUpdateDate").val(); 
    var createdby = $("#txtCreatedby").val(); 
    var updatedby = $("#txtUpdatedby").val();

    var model = {
        //3. here,forms field data binds to the models fields.
        //Title: title-->left Title is PhotoGallerymodel Field,right title is form field.
        Title: title, Image1: image1, Image2: image2, Type: type, CreateDate: createdate,
        UpdateDate: updatedate, CreatedBy: createdby, UpdatedBy: updatedby
    };
    //4.ajax call which send this data to the PhotogalleryController and its method savePhotoGallery
    $.ajax({
        url: "/PhotoGallery/savePhotoGallery",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(model),
        datatype: "json",
        success: function (response) {
            alert(response.Message);
        }


    });
}