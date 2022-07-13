(function () {

    'use etrict';

    return global = {
        BaseUrl: '/',
        BaseApiUrl: 'http://localhost:31306/api/',
        CreateRequest: createRequest  
    };

    function createRequest(url, verb, data) {

        var headers = {
            'Content-type': 'application/json;charset=utf-8',
            'Authorization': 'Bearer ' + localStorage.getItem('token')
        };

        if (data === undefined) {

            return {
                url: global.BaseApiUrl + url,
                method: verb,
                headers: headers
            }

        }
        else {

            return {
                url: global.BaseApiUrl + url,
                method: verb,
                data: {
                    Data: data
                },
                headers: headers
            }
        }
    }

})();