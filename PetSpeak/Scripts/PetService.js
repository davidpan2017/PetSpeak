

function ShowPetList() {
    var url = "/PetService.asmx";
    $.ajax({
        type: "POST",
        url: url + "/ShowPetList",
        data: "",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccessCallShowPetList,
        error: OnErrorCallShowPetList
    });
}

function OnSuccessCallShowPetList(result, eventArgs) {
    var html = $("#divPets").html(result.d);
}


function OnErrorCallShowPetList(response) {
    alert(response.status + " " + response.statusText);
}

function PetSpeak(petWords) {
    alert(petWords);
}

function GetPalindromePetList(nNumber) {
    var url = "/PetService.asmx";
    $.ajax({
        type: "POST",
        url: url + "/GetPalindromePetList",
        data: "",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccessCall,
        error: OnErrorCall
    });
}

function OnSuccessCall(result, eventArgs) {
    var nTotalItems = result.d.length;
    var shtml = $("#divPets").html();
    shtml = shtml + "<div style=\"margin-top:15px; margin-left:15px;\">Total pets found: " + nTotalItems + " ";
    var html = $("#divPets").html(shtml);
}



function OnErrorCall(response) {
    alert(response.status + " " + response.statusText);
}