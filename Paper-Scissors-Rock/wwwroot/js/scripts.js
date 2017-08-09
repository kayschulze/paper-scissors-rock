$(document).ready(function() {
  $(".player1well").click(function() {
    $("#player1").hide();
    $("#player1waiting").show();
    $("#player2waiting").hide();
    $("#player2").show();
  });

  $(".player2well").click(function() {
    $("#player1waiting").hide();
    $("#player1").show();
  });
});
