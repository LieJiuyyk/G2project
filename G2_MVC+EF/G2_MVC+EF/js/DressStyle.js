		var div1=document.getElementById("div_box-bottom-left-div-1");
		var div2=document.getElementById("div_box-bottom-left-div-2");
		var div3=document.getElementById("div_box-bottom-left-div-3");
		var div4=document.getElementById("div_box-bottom-left-div-4");
		var div5=document.getElementById("div_box-bottom-left-div-5");
		var wrap = document.getElementsByClassName("wrap")[0];
        var smallImgBox = wrap.getElementsByClassName("imgBox")[0];//div1
        var smallImg = smallImgBox.getElementsByTagName("img")[0];//图片1
        var bigImgBox = wrap.getElementsByClassName("imgBox")[1];//div2
        var bigImg = bigImgBox.getElementsByTagName("img")[0];//图片2


		div1.onmouseover=function(){
			div1.style.border="2px solid #000";
			div2.style.border="1px solid #fff";
			div3.style.border="1px solid #fff";
			div4.style.border="1px solid #fff";
            div5.style.border = "1px solid #fff";
            $.get(
                '/index/GetModelByID?id=' + id,
                {},
                function (res) {
                    smallImg.src = '/images/'+res.CpicUrl1;
                    bigImg.src = '/images/'+res.CpicUrl1;
                }
                , 'json');
            
            
		}
		div2.onmouseover=function(){
			div2.style.border="2px solid #000";
			div1.style.border="1px solid #fff";
			div3.style.border="1px solid #fff";
			div4.style.border="1px solid #fff";
			div5.style.border="1px solid #fff";
            $.get(
                '/index/GetModelByID?id=' + id,
                {},
                function (res) {
                    smallImg.src = '/images/' + res.CpicUrl2;
                    bigImg.src = '/images/' + res.CpicUrl2;
                }
                , 'json');
		}
		div3.onmouseover=function(){
			div3.style.border="2px solid #000";
			div1.style.border="1px solid #fff";
			div2.style.border="1px solid #fff";
			div4.style.border="1px solid #fff";
			div5.style.border="1px solid #fff";
            $.get(
                '/index/GetModelByID?id=' + id,
                {},
                function (res) {
                    smallImg.src = '/images/' + res.CpicUrl3;
                    bigImg.src = '/images/' + res.CpicUrl3;
                }
                , 'json');
		}
		div4.onmouseover=function(){
			div4.style.border="2px solid #000";
			div1.style.border="1px solid #fff";
			div2.style.border="1px solid #fff";
			div3.style.border="1px solid #fff";
			div5.style.border="1px solid #fff";
            $.get(
                '/index/GetModelByID?id=' + id,
                {},
                function (res) {
                    smallImg.src = '/images/' + res.CpicUrl4;
                    bigImg.src = '/images/' + res.CpicUrl4;
                }
                , 'json');
		}
		div5.onmouseover=function(){
			div5.style.border="2px solid #000";
			div1.style.border="1px solid #fff";
			div2.style.border="1px solid #fff";
			div3.style.border="1px solid #fff";
			div4.style.border="1px solid #fff";
            $.get(
                '/index/GetModelByID?id=' + id,
                {},
                function (res) {
                    smallImg.src = '/images/' + res.CpicUrl5;
                    bigImg.src = '/images/' + res.CpicUrl5;
                }
                , 'json');
		}