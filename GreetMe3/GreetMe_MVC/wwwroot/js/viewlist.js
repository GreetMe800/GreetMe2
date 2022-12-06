"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/viewHub").build();

$(function () {
    connection.start().then(function () {
        alert('Connected to ViewHub');

        InvokeViews();
    }).catch(function (err) {
        return console.error(err.toString());
    });
});

function InvokeViews() {
    connection.invoke("SendViews").catch(function (err) {
        return console.error(err.toString());
    })
}


connection.on("ReceivedViews", function (viewList) {
    BindViewsToGrid(viewList);

});

function BindViewsToGrid(viewList) {
    $('#tableViews tbody').empty();

    var tr;
    $.each(viewList, function (index, view) {
        tr = $('<tr/>');
        tr.append(`<td>${(index + 1)}</td>`)
        tr.append(`<td>${(view.viewName)}</td>`)
        tr.append(`<td>${(view.hasBirthday)}</td>`)
        tr.append(`<td>${(view.hasAnniversary + 1)}</td>`)
        $('#tableViews').append(tr);
    });
}