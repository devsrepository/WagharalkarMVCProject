var saveAppointment = function () {
    var name = $("#txtName").val();
    var email = $("#txtEmail").val(); 
    var city = $("#ddlCity").val();
    var mobileno = $("#txtMobileNo").val();
    var appointmentDate = $("#txtAppointmentDate").val();
    var gender = $("#txtGender").val(); 
    var message = $("#txtMessage").val(); 
    var createdate = $("#txtCreateDate").val();
    var updatedate = $("#txtUpdateDate").val();
    var createdby = $("#txtCreatedby").val();
    var updatedby = $("#txtUpdatedby").val();

    var model = {
        Name: name,
        Email: email,
        City: city, MobileNo: mobileno, AppointmentDate: appointmentDate,
        Gender: gender, Message: message, CreateDate: createdate, UpdateDate: updatedate,
        CreatedBy: createdby, UpdatedBy: updatedby
    };

    $.ajax({
        url: "/Appointment/saveAppointment",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(model),
        datatype: "json",
        success: function (response) {
            alert(response.Message);
        }
    });
}
