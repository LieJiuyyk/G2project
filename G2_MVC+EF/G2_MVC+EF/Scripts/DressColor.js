var yse1=document.getElementById("div_box-right-6-div-1");
	 	var yse2=document.getElementById("div_box-right-6-div-2");	
	 	var yse3=document.getElementById("div_box-right-6-div-3");	
	 	var yse4=document.getElementById("div_box-right-6-div-4");	
	 	var yse5=document.getElementById("div_box-right-6-div-5");	
	 	var yse6=document.getElementById("div_box-right-6-div-6");	
	 	var wrap    = document.getElementsByClassName("wrap")[0];
        var smallImgBox = wrap.getElementsByClassName("imgBox")[0];//div1
        var smallImg = smallImgBox.getElementsByTagName("img")[0];//图片1
        var bigImgBox = wrap.getElementsByClassName("imgBox")[1];//div2
        var bigImg = bigImgBox.getElementsByTagName("img")[0];//图片2
        yse1.onclick=function(){
        	yse1.style.border="2px solid #ff0036";
        	yse2.style.border="0.2px solid #e5e4e4";
        	yse3.style.border="0.2px solid #e5e4e4";
        	yse4.style.border="0.2px solid #e5e4e4";
        	yse5.style.border="0.2px solid #e5e4e4";
        	yse6.style.border="0.2px solid #e5e4e4";
            $.get(
                '/index/GetModelByID?id=' + id,
                {},
                function (res) {
                    smallImg.src = '/images/' + res.CpicUrl1;
                    bigImg.src = '/images/' + res.CpicUrl1;
                }
                , 'json');
        }
          yse2.onclick=function(){
        	yse2.style.border="2px solid #ff0036";
        	yse1.style.border="0.2px solid #e5e4e4";
        	yse3.style.border="0.2px solid #e5e4e4";
        	yse4.style.border="0.2px solid #e5e4e4";
        	yse5.style.border="0.2px solid #e5e4e4";
        	yse6.style.border="0.2px solid #e5e4e4";
              $.get(
                  '/index/GetModelByID?id=' + id,
                  {},
                  function (res) {
                      smallImg.src = '/images/' + res.CpicUrl2;
                      bigImg.src = '/images/' + res.CpicUrl2;
                  }
                  , 'json');
        }
          yse3.onclick=function(){
        	yse3.style.border="2px solid #ff0036";
        	yse1.style.border="0.2px solid #e5e4e4";
        	yse2.style.border="0.2px solid #e5e4e4";
        	yse4.style.border="0.2px solid #e5e4e4";
        	yse5.style.border="0.2px solid #e5e4e4";
        	yse6.style.border="0.2px solid #e5e4e4";
              $.get(
                  '/index/GetModelByID?id=' + id,
                  {},
                  function (res) {
                      smallImg.src = '/images/' + res.CpicUrl3;
                      bigImg.src = '/images/' + res.CpicUrl3;
                  }
                  , 'json');
        }
            yse4.onclick=function(){
        	yse4.style.border="2px solid #ff0036";
        	yse1.style.border="0.2px solid #e5e4e4";
        	yse2.style.border="0.2px solid #e5e4e4";
        	yse3.style.border="0.2px solid #e5e4e4";
        	yse5.style.border="0.2px solid #e5e4e4";
        	yse6.style.border="0.2px solid #e5e4e4";
                $.get(
                    '/index/GetModelByID?id=' + id,
                    {},
                    function (res) {
                        smallImg.src = '/images/' + res.CpicUrl4;
                        bigImg.src = '/images/' + res.CpicUrl4;
                    }
                    , 'json');
        }
            yse5.onclick=function(){
        	yse5.style.border="2px solid #ff0036";
        	yse1.style.border="0.2px solid #e5e4e4";
        	yse2.style.border="0.2px solid #e5e4e4";
        	yse3.style.border="0.2px solid #e5e4e4";
        	yse4.style.border="0.2px solid #e5e4e4";
        	yse6.style.border="0.2px solid #e5e4e4";
                $.get(
                    '/index/GetModelByID?id=' + id,
                    {},
                    function (res) {
                        smallImg.src = '/images/' + res.CpicUrl5;
                        bigImg.src = '/images/' + res.CpicUrl5;
                    }
                    , 'json');
        }
            yse6.onclick=function(){
        	yse6.style.border="2px solid #ff0036";
        	yse1.style.border="0.2px solid #e5e4e4";
        	yse2.style.border="0.2px solid #e5e4e4";
        	yse3.style.border="0.2px solid #e5e4e4";
        	yse4.style.border="0.2px solid #e5e4e4";
        	yse5.style.border="0.2px solid #e5e4e4";
                $.get(
                    '/index/GetModelByID?id=' + id,
                    {},
                    function (res) {
                        smallImg.src = '/images/' + res.CpicUrl6;
                        bigImg.src = '/images/' + res.CpicUrl6;
                    }
                    , 'json');
        }
