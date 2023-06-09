// pagination.js

$(document).ready(function () {
    // Attach click event handler to pagination links
    $('#pagination-controls a').on('click', function (e) {
        e.preventDefault();

        // Get the page index from the clicked link
        var pageIndex = $(this).data('page-index');
        var pageSize = @ViewBag.PageSize;

        // Make an AJAX request to fetch the data for the selected page
        $.ajax({
            url: '/Employee/Index',
            data: {
                pageIndex: pageIndex,
                pageSize: pageSize
            },
            success: function (data) {
                // Replace the table body with the updated data
                $('tbody').html(data);
            }
        });
    });
});
