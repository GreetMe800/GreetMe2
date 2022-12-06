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
        tr.append(`<th scope="row">${(index + 1)}</th>`)
        tr.append(`<td>${(view.viewName)}</td>`)
        tr.append(`<td>${(view.hasBirthday)}</td>`)
        tr.append(`<td>${(view.hasAnniversary)}</td>`)

        //tr.append('<td><a href="/ControllerName/ActionName/"' + val.empID + '"></a></td>');
        tr.append('<td><a href="/Views/Display/"' + view.id + '">Display</a> | <a href="/Views/Details/"' + view.id + '">Details</a> | <a href="/Views/Edit/"' + view.id + '">Edit</a> | <a href="/Views/Delete/"' + view.id + '">Delete</a></td>');

        $('#tableViews').append(tr);
    });
}

//@Html.ActionLink("Details", "Details", new { id=item.Id }) |
//@Html.ActionLink("Edit", "Edit", new { id=item.Id }) |
//@Html.ActionLink("Delete", "Delete", new { id=item.Id })