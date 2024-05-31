namespace JWTAuthenticationDemo.Models
{
	public class UserConstants
	{
		// fetch the user & its role from DB
		public static List<UserModel> Users = new()
			{
					new UserModel(){ Username="admin",Password="admin",Role="Admin"},
					new UserModel(){ Username="user",Password="user",Role="Customer"}
			};
	}

}
