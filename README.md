# qase-net-api
# [Qase TMS](https://qase.io) .Net Api Client

## Usage ##
Qase.io uses API tokens to authenticate requests. You can view an manage your API keys in [API tokens pages](https://app.qase.io/user/api/token).

You must replace api token with your personal API key.

```C#
QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
```

### Projects ###

#### Get All Projects ####
This method allows to retrieve all projects available for your account. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.limit = 100;
filter.offset = 0;
var projects = await qaseAPI.GetAllProjectsAsync(filter);
```

