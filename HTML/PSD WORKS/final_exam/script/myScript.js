function firstMenu(){
$('ul .submenu').hide();
$('ul li:first').click(function(e){
	e.preventDefault();
$('ul .submenu').slideDown('slow');


});
$('.cancel').click(function(e){
	e.preventDefault();
	$('ul .submenu').slideUp('slow');
});



}
function hoverMenu(){
$('.menu2 a:first').hover(function(){
	$('.electric').show();
	$('.products,.services,.news').hide();
});
$('.menu2 a:eq( 1 )').hover(function(){
	$('.electric,.services,.news').hide();
	$('.products').show();
});
$('.menu2 a:eq( 2 )').hover(function(){
	$('.electric,.products,.news').hide();
	$('.services').show();
});
$('.menu2 a:eq( 3 )').hover(function(){
$('.electric,.products,.services').hide();
$('.news').show();


});

}
function olw(){
	$("#owl").owlCarousel({
 
      autoPlay: 3000, 
 
      items : 4,
      itemsDesktop : [1199,3],
      itemsDesktopSmall : [979,3]
 
  });


}
function scrollDiv(){
	var scrollingDiv = $("#fly");
$(window).scroll(function(){

scrollingDiv.stop().animate({"top": ($(window).scrollTop() + 70) + "px"}, "slow" );
$('#fly a' ).click(function(e){
		e.preventDefault();
});				
			



});
$('#fly .outer').click(function(){
$('#fly .inner').show('slow');


});
$('#fly .remove').click(function(){
	$('#fly .inner').hide('slow');
});

$('.clear a').click(function(e){
e.preventDefault();
});

}
function animateL(){
	$('#highlight .inition').click(function(){
	 $('#highlight .anime1 ').animate({backgroundColor: '#f8f7c0'}, 500,function(){
	 	$(this).animate({backgroundColor: '#f0ee80'}, 500,function(){
	 		$('#highlight .anime2 ').animate({backgroundColor: '#f8f7c0'}, 500,function(){
		$(this).animate({backgroundColor: '#f0ee80'}, 500,function(){
			$('#highlight .anime3 ').animate({backgroundColor: '#f8f7c0'}, 500,function(){
				$(this).animate({backgroundColor: '#f0ee80'}, "slow",function(){
					$('#highlight .inition ').animate({backgroundColor: '#f8f7c0'}, 500)

				})
			})
		})
	})
	 	})
	 })
	
	




	});

$('#highlight li').hover(function(){
	$(this).css("background-color", '#f8f7c0');

	
},function(){
	$(this).css("background-color", "#f0ee80");
})



	

}











$(document).ready(function(){

firstMenu();
hoverMenu();
olw();
scrollDiv();
animateL();



});