interface UserData {
    userId: number;
    username: string;
    email: string;
    role: UserRole;
  }
  
  type UserRole = 'admin' | 'user';
  
  export default UserData;
  