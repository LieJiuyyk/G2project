window.onload = function () {
    new Vue({
        el: "#Big_box",
        data: {
            input:'',
            lists: [
                { id: 1, name: '苹果', price: 12, count: 1, url: 'images/苹果.jpg' },
                { id: 2, name: '梨子', price: 10, count: 1, url: 'images/梨子.jpg' },
                { id: 3, name: '芒果', price: 15.5, count: 1, url: 'images/芒果.jpg' },
                { id: 4, name: '香蕉', price: 4, count: 1, url: 'images/香蕉.jpg' },
                { id: 5, name: '火龙果', price: 12, count: 1, url: 'images/火龙果.jpg' },
            ]
        },
        methods: {

        },
        filters: {
            //过滤器   文本格式化
            pricefill: function (data, n) {
                return '￥' + data.toFixed(n);
            }
        },
            computed:{
                //计算属性
                //计算商品数
                suncount:function () {
                    var n = 0;
                    this.lists.forEach(function (item) {
                        n += item.count;
                    })
                    return n;
                },
                //计算总价格
                pricecount: function () {
                    var n = 0;
                    this.lists.forEach(function (item) {
                        n += item.count * item.price;
                    })
                    return n;
                },
                //模糊查询
                searchData: function () {
                    if (!this.input) {
                        return this.lists;
                    };
                    return this.lists.filter(item => {
                        return item.name.includes(this.input);
                    })
                }
        }
    })
}