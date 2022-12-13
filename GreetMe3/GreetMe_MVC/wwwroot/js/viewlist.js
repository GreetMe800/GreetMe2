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

//Viewlist
function BindViewsToGrid(viewList) {
    $('#tableViews tbody').empty();

    var tr;
    $.each(viewList, function (index, view) {
        tr = $('<tr/>');
        tr.append(`<th scope="row">${(index + 1)}</th>`)
        tr.append(`<td>${(view.viewName)}</td>`)

        //hasBirthday
        if (view.hasBirthday) {
            tr.append(`<td><input type="checkbox" checked disabled></td>`)
        } else {
            tr.append(`<td><input type="checkbox" disabled></td>`)
        }

        //hasAnniversary
        if (view.hasAnniversary) {
            tr.append(`<td><input type="checkbox" checked disabled></td>`)
        } else {
            tr.append(`<td><input type="checkbox" disabled></td>`)
        }
        }

        tr.append(`<td><input type="checkbox"` + BoolCheck(view.hasAnniversary) + `disabled></td>`)

        //tr.append(`<td>| <a href="/Controllername/ActionName/${object.id}">Display</a></td>`);
        tr.append(`<td><a href="/Views/Display/${view.id}">Display</a> | <a href="/Views/Details/${view.id}">Details</a> | <a href="/Views/Edit/${view.id}">Edit</a> | <a href="/Views/Delete/${view.id}">Delete</a></td>`);

        $('#tableViews').append(tr);
    });
}

//@Html.ActionLink("Details", "Details", new { id=item.Id }) |
//@Html.ActionLink("Edit", "Edit", new { id=item.Id }) |
//@Html.ActionLink("Delete", "Delete", new { id=item.Id })

//<div class="form-group form-check mb-3">
//    <label class="form-check-label">
//        <input class="form-check-input" asp-for="HasBirthday" />
//                    @Html.DisplayNameFor(model => model.HasBirthday)
//    </label>
//</div>