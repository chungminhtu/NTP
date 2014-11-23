$(document).ready(function() {
    $("select[id$='cboPanes']").change(function() {
        if ($("input[value='LAYOUT'][checked]").length == 0) {
    
            var paneId = $("select[id$='cboPanes'] option:selected").text();
            var pane = $("td[id$='" + paneId + "']");
            var isHidden = (pane.height() < 2);

            if (isHidden) {
                //var hiddenpanes = $(".DNNEmptyPane").toggleClass("DNNEmptyPane").append("<div class='_DNNRemove' style='height:25px' />");
                pane.removeClass("DNNEmptyPane").append("<div class='_DNNRemove' style='height:0px' />");
                $("._DNNRemove").animate({ height: 29 }, "fast");
            }

            var size = { width: (pane.width() < 150 ? 150 : pane.width()), height: (pane.height() < 25 ? 25 : pane.height()) };
            var offset = pane.offset();

            var highlight = $('#dnnPaneHighlight');
            if (highlight.length < 1) {
                highlight = $("<div id='dnnPaneHighlight' style='position:absolute;border:2px dashed #777;text-align:center;font-weight:bold;font-size:1.2em;display:none;' />")
                    .appendTo("#Body");
            }

            highlight.css("top", offset.top)
                    .css("left", offset.left)
                    .width(size.width)
                    .height(size.height)
                    .text(paneId)
                    .fadeIn(1000)
                    .fadeOut(1000);

            if (isHidden) {
                //            $("._DNNRemove").animate({ opacity: 1.0 }, 2000, function() { $(this).remove() });
                //            hiddenpanes.toggleClass("DNNEmptyPane");
                $("._DNNRemove").animate({ opacity: 1.0 }, 2000).animate({height: 0}, "fast", function() { $(this).remove() });
                pane.addClass("DNNEmptyPane");

            }
        }
    });
});
