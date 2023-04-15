using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HotelManagment_Day11.ViewModels
{
    public class BaseViewModel : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        #region  INOtifyDataErrorInfo

        private readonly Dictionary<string , List<string>> _ErrorDictionary = new Dictionary<string , List<string>>( )
        {
            {defaulError,new List<string>{""} }
        };

        private static string defaulError = "defaultError";
        public bool HasErrors => _ErrorDictionary.Any( );
        public bool btnSubmitEnabeled => !HasErrors;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;


        public IEnumerable GetErrors( string? propertyName )
        {
            return _ErrorDictionary.GetValueOrDefault( propertyName , null );
        }
        public void AddError( string errorMassage , [CallerMemberName] string propertyName = null )
        {

            if ( !_ErrorDictionary.ContainsKey( propertyName ) )
                _ErrorDictionary.Add( propertyName , new List<string>( ) );
            _ErrorDictionary[ propertyName ].Add( errorMassage );
            OnErrorChanged( propertyName );
        }
        public void RemoveErrorsIfExist( [CallerMemberName] string propertyName = null )
        {
            if ( _ErrorDictionary.ContainsKey( propertyName ) )
            {
                _ErrorDictionary.Remove( propertyName );
                OnErrorChanged( propertyName );
            }
        }
        private void OnErrorChanged( string propertyName )
        {
            onPropertyChanged( nameof( btnSubmitEnabeled ) );
            ErrorsChanged?.Invoke( this , new DataErrorsChangedEventArgs( propertyName ) );
        }
        protected void RemoveDefaultError( )
        {

            _ErrorDictionary.Remove( defaulError );
            OnErrorChanged( defaulError );

        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void onPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( propertyName ) );
        }
        #endregion
    }
}
