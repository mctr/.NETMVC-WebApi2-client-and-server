//Toplantı bilgilerini listelediğimiz fonksiyon
function MeetingList() {
    $("#tblMeeting").html(""); // Önce elementin içini temizledik
    
    $.getJSON("http://localhost:3413/api/Meeting", function (data) { // verilen linkten gelen JSON verilere data isimli degişkene atıyoruz.
            $.each(data, function (i, item) { // each fonksiyonu ile data verisinin içerisinde dolaşıyoruz.foreach gibi
                $("#tblMeeting").append( // burada da gelen verilerimizi tablomuza ekliyoruz 
                    "<tr><td>" + item.MeetingTopic + "</td>" +
                    "<td>" + item.MeetingDate + "</td>" +
                    "<td>" + item.MeetingStartTime + "</td>" +
                    "<td>" + item.MeetingFinishTime + "</td>" +
                    "<td>" + item.Participants + "</td>" +
                    "<td><input type='submit' class='btn btn-primary' onclick='MeetingFetch(\"" + item.id + "\");'  value='Güncelle' /></td></tr>" //Güncelle butonuna onclick metodu yazıldı => MeetingFetch(id)
                    );
            });
    })

}

//Toplantı eklediğimiz fonksiyondur. Toplantı Ekle butonuna tıklandığında bu fonksiyon çalışacak ve api/Meeting linkine bilgileri post edecek
function MeetingAdd() {
    $.ajax({
        type: "POST",
        url: "http://localhost:3413/api/Meeting",
        data: $("#MeetingAddForm").serialize(),
        success: function () {
            alert("Toplantı Ekleme Başarılı..");
        }
    });
}

function MeetingFetch(id) {
    $.getJSON("http://localhost:3413/api/Meeting/" + id)
        .done(function (data) {
            $("#MeetingUpdateForm #MeetingTopic").val(data.MeetingTopic);
            $("#MeetingUpdateForm #MeetingDate").val(data.MeetingDate);
            $("#MeetingUpdateForm #MeetingStartTime").val(data.MeetingStartTime);
            $("#MeetingUpdateForm #MeetingFinishTime").val(data.MeetingFinishTime);
            $("#MeetingUpdateForm #Participants").val(data.Participants);
            $("#MeetingUpdateForm #btnMeetingUpdate").attr("onclick", "MeetingUpdate('" + data.id + "');");
        })
}

function MeetingUpdate(id) {
    $.ajax({
        type: "PUT",
        url: "http://localhost:3413/api/Meeting/" + id,
        data: $("#MeetingUpdateForm").serialize(),
        success: function () {
            alert("Toplantı Güncelleme Başarılı..");
            MeetingList();
        }
    })
}