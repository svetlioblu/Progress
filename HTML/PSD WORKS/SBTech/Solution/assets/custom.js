$(document).ready(function(){
(function(){
 $(".extend").click(function(){

        $(".sub-menu").toggle(function(){
        	$(".extend").toggleClass('arrowchange');
        	$(".extend").toggleClass('arrowdown');


        });
        
    });
})();
(function(){
$("#toggle li a").click(function(e){
  e.preventDefault();
  var $div = $(this).next('.hiddencontainer');
  $(".hiddencontainer").not($div).hide();
    if ($div.is(":visible")) {
            
            $(this).text("Click to open");
            $(this).removeClass('arrowdowncolumn');
            $(this).addClass('arrowrightcolumn');
            $div.hide();
        }  else {
           
           $(this).text("Click to close");
            $(this).removeClass('arrowrightcolumn');
             $(this).addClass('arrowdowncolumn');
             $div.show();
           
        }

    });
       
  $(document).click(function(e){
       var p = $(e.target).closest('#toggle li').length;
       if (!p) {
          $(".hiddencontainer").hide();
       }
   });


$(".languageList img").click(function(){
 $(this).css('border-color','black');
   $(".languageList img").not($(this)).css('border-color','#959595');
       
});
     
})(); 
});






